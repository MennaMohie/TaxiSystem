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

        //khaleha vector
        Dictionary<string, ClientTrip> ClientTrip_ = new Dictionary<string, ClientTrip>();


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

        //Reserving a taxi
        public void ReserveTaxi(Client Sender)
        {
        }

        public void ViewClientHistory()
        {
        }
    }
}
