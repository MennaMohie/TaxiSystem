using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace Taxi_Management_System
{
    public static class DriverGlobals
    {
        public static Queue<Driver> FreeDrivers = new Queue<Driver>();
        public static Dictionary<string, Driver> DriverMap = new Dictionary<string, Driver>();
    }

    public class DriverTrip
    {
        public string DriverTripID;
        public string ClientName;
        public string From;
        public string To;
    }

    public class Driver
    {
        public string DriverUsername;
        public string DriverPassword;
        public string DriverName;
        public string DriverID;
        public string CarID;
        public string Salary;
        public string Status;
        Dictionary<string, DriverTrip> DriverTrip_ = new Dictionary<string, DriverTrip>();

        //Functions
        //Filling the map of drivers
        public bool FillDriverMap()
        {
            return true;
        }

        //Login Function for the driver
        public void DriverLogin(string uname, string password)
        {
        }
        //Function to change the Driver Status

        public void ChangeStatus(string name)
        {
        }

        //Recieving a request
        public void RecieveRequest(Driver FreeDriver_, Client Customer)
        {
        }

    }
}
