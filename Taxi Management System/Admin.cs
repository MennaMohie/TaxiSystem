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
        public void viewtrips ()
        {
            for (int i=0; i<AllTrips.Count; i++)
            {
                Console.WriteLine(AllTrips[i].ClientName);
                Console.WriteLine(AllTrips[i].DriverName);
                Console.WriteLine(AllTrips[i].From);
                Console.WriteLine(AllTrips[i].To);
                Console.WriteLine(AllTrips[i].thisday);
            }
        }
        public void addnewdriver (string uname,string password , string name , string driverid , string carid , string salary , string status)
        {
            Driver tempdriver=new Driver();
            tempdriver.DriverUsername = uname;
            tempdriver.DriverPassword = password;
            tempdriver.DriverName = name;
            tempdriver.DriverID = driverid;
            tempdriver.CarID = carid;
            tempdriver.Salary = salary;
            tempdriver.Status = status;
            DriverGlobals.DriverMap[uname] = tempdriver;

        }
    }
}
