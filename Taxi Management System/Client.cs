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
        public static Dictionary<string, Client> NewClients = new Dictionary<string, Client>();

    }

    public class Client
    {

        public string ClientUsername;
        public string ClientName;
        public string ClientID;
        public string ClientPassword;
        List<Trip> ClientTrip_ = new List<Trip>();

        //Functions
        //Filling the map of clients
        public void FillCientMap()
        {
            StreamReader Stream = new StreamReader(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Clients.txt");
            //StreamReader Stream = new StreamReader("Clients.txt");

            char[] Delimeters = { ' ', ',', '.', ':', '\t' };
            string Line = Stream.ReadLine();
        
            while(!string.IsNullOrWhiteSpace(Line))
            {
                Client tempClient = new Client();
                string[] Words = Line.Split(Delimeters);

                tempClient.ClientUsername = Words[0];
                tempClient.ClientName = Words[1] + ' ' + Words[2];
                tempClient.ClientID = Words[3];
                tempClient.ClientPassword = Words[4];

                ClientGlobals.ClientMap[tempClient.ClientUsername] = tempClient;
                
                Line = Stream.ReadLine();
            }

            Stream.Close();
        }

        //Client Registeration
        public bool ClientRegister(Client Reg, string confirm)
        {
            if (!string.IsNullOrEmpty(Reg.ClientName) && !string.IsNullOrEmpty(Reg.ClientUsername)
                && !string.IsNullOrEmpty(Reg.ClientPassword) && !string.IsNullOrEmpty(confirm))
            {
                if (confirm == Reg.ClientPassword)
                {
                    if (ClientGlobals.ClientMap.ContainsKey(Reg.ClientUsername))
                    {
                        MessageBox.Show("Username is taken, please choose another one.");
                        return false;
                    }
                    else
                    {
                        Reg.ClientID = ((ClientGlobals.ClientMap.Count) + 1).ToString();
                        ClientGlobals.ClientMap.Add(Reg.ClientUsername, Reg);
                        ClientGlobals.NewClients.Add(Reg.ClientUsername, Reg);
                        MessageBox.Show("Registration completed successfully.");
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Confirm Password field doesn't mattch the Password field.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please fill the empty fields.");
                return false;
            }   
        }

        public void ReserveTaxi(string clientUsername, string From_ , string To_ )
        {
            Trip TempTrip = new Trip();

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