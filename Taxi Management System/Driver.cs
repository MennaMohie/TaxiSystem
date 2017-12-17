using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;


namespace Taxi_Management_System
{
    public static class DriverGlobals
    {
        public static Queue<Driver> FreeDrivers = new Queue<Driver>();
        public static Dictionary<string, Driver> DriverMap = new Dictionary<string, Driver>();
    }

    public class DriverTrip
    {
        public string ClientName;
        public string DriverName;
        public DateTime Date;
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
        List<DriverTrip> DriverTrip_ = new List<DriverTrip>();

        //Functions
        //Filling the map of drivers
        public bool FillDriverMap()
        {
            StreamReader Stream = new StreamReader("Drivers.txt");

            char[] Delimeters = { ' ', ',', '.', ':', '\t' };
            string Line = Stream.ReadLine();
            Driver tempDriver = new Driver();

            while (Line != null)
            {
                string[] Words = Line.Split(Delimeters);

                tempDriver.DriverUsername = Words[0];
                tempDriver.DriverPassword = Words[1];
                tempDriver.DriverName = Words[2] + ' ' + Words[3];
                tempDriver.DriverID = Words[4];
                tempDriver.Salary = Words[5];
                tempDriver.Status = Words[6];

                DriverGlobals.DriverMap[tempDriver.DriverUsername] = tempDriver;
                
            }
            return true;
        }

        //Login Function for the driver
        public void DriverLogin(string uname, string password)
        {
            if (DriverGlobals.DriverMap.ContainsKey(uname))
            {
                if(DriverGlobals.DriverMap[uname].DriverPassword == password)
                {
                    Application.Run(new Driver_Home());
                }
                else
                {
                    MessageBox.Show("Either username or password is incorrent, please try again.");
                }
            }
            else
            {
                MessageBox.Show("You are not a registered driver, please contact an admin to register.");
            }
        }

        //Function to change the Driver Status
        public void ChangeStatus(string name)
        {
            if (DriverGlobals.DriverMap[name].Status == "0")
            {
                DriverGlobals.DriverMap[name].Status = "1";
                DriverGlobals.FreeDrivers.Enqueue(DriverGlobals.DriverMap[name]);
            }
            else
            {
                DriverGlobals.DriverMap[name].Status = "0";
            }
        }

        //Recieving a request
        public void RecieveRequest(Driver FreeDriver_, Client Customer)
        {
            DriverTrip TempTrip = new DriverTrip();
            FreeDriver_.ChangeStatus(FreeDriver_.DriverUsername);
            TempTrip.ClientName = Customer.ClientName;
            TempTrip.From = "hakhodha mn textbox";
            TempTrip.To = "hakhodha mn textbox ely taht ely foo'";
            TempTrip.Date = DateTime.Today;
            DriverTrip_.Add(TempTrip);

            //////////////////////////Send trip data to the admin List
            Admin.Trip TempTripp = new Admin.Trip();
            TempTripp.DriverName = FreeDriver_.DriverName;
            TempTripp.ClientName = TempTrip.ClientName;
            TempTripp.From = TempTrip.From;
            TempTripp.To = TempTrip.To;
            TempTripp.thisday = TempTrip.Date;

            Admin TempAdmin = new Admin();
            TempAdmin.SendTripData(TempTripp);
        }

        public void ViewdriverHistory(string uname)
        {
            int num_trips;
            num_trips = DriverGlobals.DriverMap[uname].DriverTrip_.Count;
            for (int i = 0; i < num_trips; i++)
            {
                Console.WriteLine(DriverGlobals.DriverMap[uname].DriverTrip_[i]);
            }
    }
}
}
