using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Taxi_Management_System
{

    public static class ClientGlobals
    {
        public static Dictionary<string, Client> ClientMap = new Dictionary<string, Client>();
    }

    public class ClientTrip
    {
        public string DriverName;
        public DateTime Date;
        public string From;
        public string To;
    }

    public class Client
    {

        public string ClientUsername;
        public string ClientName;
        public string ClientID;
        public string ClientPassword;
        List<ClientTrip> ClientTrip_ = new List<ClientTrip>();

        //Functions
        //Filling the map of clients
        public bool FillCientMap()
        {
            StreamReader Stream = new StreamReader(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Clients.txt");

            char[] Delimeters = { ' ', ',', '.', ':', '\t' };
            string Line = Stream.ReadLine();
            Client tempClient = new Client();
           
            while(!string.IsNullOrWhiteSpace(Line))
            {
                string[] Words = Line.Split(Delimeters);

                tempClient.ClientUsername = Words[0];
                tempClient.ClientName = Words[1] + ' ' + Words[2];
                tempClient.ClientID = Words[3];
                tempClient.ClientPassword = Words[4];

                ClientGlobals.ClientMap[tempClient.ClientUsername] = tempClient;

                Line = Stream.ReadLine();
            }
            

            return true;
        }

        //Client Registeration
        public void ClientRegister(Client Reg, string confirm)
        {
            if (!string.IsNullOrEmpty(Reg.ClientName) && !string.IsNullOrEmpty(Reg.ClientUsername)
                && !string.IsNullOrEmpty(Reg.ClientPassword) && !string.IsNullOrEmpty(confirm))
            {
                if (confirm == Reg.ClientPassword)
                {
                    if (ClientGlobals.ClientMap.ContainsKey(Reg.ClientUsername))
                    {
                        MessageBox.Show("used user name, please write another one");
                    }
                    else
                    {
                        Reg.ClientID = ((ClientGlobals.ClientMap.Count) + 1).ToString();
                        ClientGlobals.ClientMap.Add(Reg.ClientUsername, Reg);
                        MessageBox.Show("Registration Completed successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Confirm password doesn’t match password ");
                }
            }
            else
            {
                MessageBox.Show("Please fill the empty text boxes");
            }

            
        }

        //Login Function for the client
        public void ClientLogin(string uname, string password)
        {
            if (ClientGlobals.ClientMap.ContainsKey(uname))
            {
                if (ClientGlobals.ClientMap[uname].ClientPassword == password )
                {
                    Program.client.ClientUsername = uname;
                    clientHome ClientHome = new clientHome();
                    ClientHome.Show();               
                }
                else
                {
                    MessageBox.Show("Username or password incorrect, please try again.");
                }
            }
            else
            {
                MessageBox.Show("User doesn't exist, please register.");
                Register r = new Register();
                r.Show();
            }
        }

        public void ReserveTaxi(string clientUsername, string From_ , string To_ )
        {
            ClientTrip TempTrip = new ClientTrip();

            string driverUsername;
            while(DriverGlobals.FreeDrivers.Count!=0)
            {
                driverUsername = DriverGlobals.FreeDrivers.Peek().DriverUsername;
                if(DriverGlobals.DriverMap[driverUsername].Status=="1")
                {
                    MessageBox.Show(@"Reservation complete.
                                      The Driver's name: " + driverUsername + ".");
                    DriverGlobals.FreeDrivers.Peek().RecieveRequest(DriverGlobals.FreeDrivers.Peek(), ClientGlobals.ClientMap[clientUsername]);
                    TempTrip.DriverName = DriverGlobals.FreeDrivers.Peek().DriverName;
                    TempTrip.From = From_;
                    TempTrip.To = To_;
                    TempTrip.Date = DateTime.Today;
                    ClientTrip_.Add(TempTrip);
                    DriverGlobals.FreeDrivers.Dequeue();
                    break;
                }
                else
                {
                    DriverGlobals.FreeDrivers.Dequeue();
                }
            }
        }

        public void ViewClientHistory( string uname)
        {
            int num_trips;
            num_trips=  ClientGlobals.ClientMap[uname].ClientTrip_.Count;
            for (int i = 0; i < num_trips; i++)
            {
                Console.WriteLine(ClientGlobals.ClientMap[uname].ClientTrip_[i].DriverName);
                Console.WriteLine(ClientGlobals.ClientMap[uname].ClientTrip_[i].From);
                Console.WriteLine(ClientGlobals.ClientMap[uname].ClientTrip_[i].To);
                Console.WriteLine(ClientGlobals.ClientMap[uname].ClientTrip_[i].Date);
            }
        }
    }
}