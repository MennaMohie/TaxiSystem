using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_Management_System
{
    public class Admin
    {
        public static class AdminGlobals
        {
            public static Dictionary<string, Admin> AdminMap = new Dictionary<string, Admin>();
        }
            public List<Trip> AllTrips = new List<Trip>();

        public class Trip
        {
            public string DriverName;
            public string ClientName;
            public string From;
            public string To;
            public DateTime thisday;
        }

        string AdminName;
        string AdminPassword;

        public bool FillAdminMap()
        {
            return true;
        }

        public void SendTripData(Admin.Trip Trip)
        {
            AllTrips.Add(Trip);
        }
    }
}
