using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            StreamReader Stream = new StreamReader("Clients.txt");

            char[] Delimeters = { ' ', ',', '.', ':', '\t' };
            string Line = Stream.ReadLine();
            Client tempClient = new Client();

            while(Line!= null)
            {
                string[] Words = Line.Split(Delimeters);

                tempClient.ClientUsername = Words[0];
                tempClient.ClientName = Words[1] + ' ' + Words[2];
                tempClient.ClientID = Words[3];
                tempClient.ClientPassword = Words[4];

                ClientGlobals.ClientMap[tempClient.ClientUsername] = tempClient;    
            }

            return true;
        }

        //Client Registeration
        public void ClientRegister()
        {
        }

        //Login Function for the client
        public void ClientLogin(string uname, string password)
        {
        }

        public void ReserveTaxi(Client Sender , string From_ , string To_ )
        {
            ClientTrip TempTrip = new ClientTrip();
            bool notFree = true;
            while (notFree)
            {
                if (DriverGlobals.DriverMap[Sender.ClientUsername].Status == "1")
                {
                    Console.WriteLine("Reservation is done!");
                    Console.WriteLine("The Driver Name: " + DriverGlobals.FreeDrivers.Peek().DriverName);
                    DriverGlobals.FreeDrivers.Peek().RecieveRequest(DriverGlobals.FreeDrivers.Peek(), Sender);
                    TempTrip.DriverName = DriverGlobals.FreeDrivers.Peek().DriverName;
                    TempTrip.From = From_;
                    TempTrip.To = To_;
                    TempTrip.Date = DateTime.Today; 
                    ClientTrip_.Add(TempTrip);
                    notFree = false;
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
                Console.WriteLine(ClientGlobals.ClientMap[uname].ClientTrip_[i]);         
            }
        }
    }
}