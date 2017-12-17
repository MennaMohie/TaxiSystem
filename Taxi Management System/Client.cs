using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Taxi_Management_System
{
    public class Client
    {
        public static class ClientGlobals
        {
            public static Dictionary<string, Client> ClientMap = new Dictionary<string, Client>();
        }

        public class ClientTrip
        {
            public string ClientTripID;
            public string DriverName;
            public string From;
            public string To;
        }

        public string ClientUsername;
        public string ClientName;
        public string ClientID;
        public string ClientPassword;
        Dictionary<string, ClientTrip> ClientTrip_ = new Dictionary<string, ClientTrip>();


        //Functions
        //Filling the map of clients
        public bool FillCientMap()
        {
            char[] Delimeters = { ' ', '.', ',', ':', '\t' };
            StreamReader Stream = new StreamReader("Clients.txt");
            string Line = Stream.ReadLine();

            while (Line != null)
            {
                Client TempClient = new Client();
                string[] Words = Line.Split(Delimeters);
                TempClient.ClientUsername = Words[0];
                TempClient.ClientName = Words[1];
                TempClient.ClientID = Words[2];
                TempClient.ClientPassword = Words[3];


                //Sending the attributes to the MAP, Key -> USERNAME , Value -> Object of client Class
                ClientGlobals.ClientMap.Add(TempClient.ClientUsername, TempClient);
                Line = Stream.ReadLine();
            }
            return true;
        }

        //Client Registeration
        public void ClientRegister()
        {
            Client NewClient = new Client();
            Console.WriteLine("Please enter your username: ");
            NewClient.ClientUsername = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            NewClient.ClientPassword = Console.ReadLine();
            Console.WriteLine("Please enter your ID: ");
            NewClient.ClientID = Console.ReadLine();
            Console.WriteLine("Please enter your first name: ");
            NewClient.ClientName = Console.ReadLine();
            ClientGlobals.ClientMap.Add(NewClient.ClientUsername, NewClient);
            Console.WriteLine("Registeration is done!");

            //Fadel eny a3adel fel file bel map
        }

        //Login Function for the client
        public void ClientLogin(string uname, string password)
        {
            if (ClientGlobals.ClientMap[uname].ClientPassword == password)
            {
                Console.WriteLine("You are now logged in.");
            }
            else
            {
                Console.WriteLine("Username or Password incorrect.");
            }
        }

        //Reserving a taxi
        public void ReserveTaxi(Client Sender)
        {
            ClientTrip TempTrip = new ClientTrip();
            bool notFree = true;
            while (notFree)
            {
                if (DriverGlobals.FreeDrivers.Peek().Status == "1")
                {
                    Console.WriteLine("Reservation is done!");
                    Console.WriteLine("The Driver Name: " + DriverGlobals.FreeDrivers.Peek().DriverName);
                    DriverGlobals.FreeDrivers.Peek().RecieveRequest(DriverGlobals.FreeDrivers.Peek(), Sender);
                    TempTrip.DriverName = DriverGlobals.FreeDrivers.Peek().DriverName;
                    TempTrip.ClientTripID = DriverGlobals.FreeDrivers.Peek().DriverID;
                    TempTrip.From = "hakhodha mn l textbox";
                    TempTrip.To = "hakhodha mn l textbox ely tahteeeh";
                    ClientTrip_.Add(Sender.ClientUsername, TempTrip);
                    notFree = false;
                    break;
                }
                else
                {
                    DriverGlobals.FreeDrivers.Dequeue();
                }
            }
        }

        public void ViewClientHistory()
        {

        }
    }
}
