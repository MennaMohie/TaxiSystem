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
        public string Date;
        public string From;
        public string To;
    }

    public class Client
    {

        public string ClientUsername;
        public string ClientName;
        public string ClientID;
        public string ClientPassword;

        //khaleha vector
        List<ClientTrip> ClientTrip_ = new List<ClientTrip>();


        //Functions
        //Filling the map of clients
        public bool FillCientMap()
        {
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