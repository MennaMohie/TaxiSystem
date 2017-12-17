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
            char[] Delimeters = { ' ', '.', ',', ':', '\t' };
            StreamReader Stream = new StreamReader("Drivers.txt");
            string Line = Stream.ReadLine();

            while (Line != null)
            {
                string[] Words = Line.Split(Delimeters);

                //Filling the Object of Driver Class
                Driver TempDriver = new Driver();
                TempDriver.DriverUsername = Words[0];
                TempDriver.DriverID = Words[1];
                TempDriver.DriverName = Words[2];
                TempDriver.CarID = Words[3];
                TempDriver.Salary = Words[4];
                TempDriver.Status = Words[5];
                TempDriver.DriverPassword = Words[6];

                //Filling the free drivers in a queue
                if (TempDriver.Status == "1")
                {
                    DriverGlobals.FreeDrivers.Enqueue(TempDriver);
                }

                //Sending the attributes to the MAP, Key -> USERNAME , Value -> Object of Driver Class
                DriverGlobals.DriverMap.Add(TempDriver.DriverUsername, TempDriver);
                Line = Stream.ReadLine();

            }
            Console.WriteLine("Driver Map is filled successfully");
            return true;
        }

        //Login Function for the driver
        public void DriverLogin(string uname, string password)
        {
            if (DriverGlobals.DriverMap[uname].DriverPassword == password)
            {
                Console.WriteLine("You are now logged in.");
            }
            else
            {
                Console.WriteLine("Username or Password incorrect.");
            }
        }
        //Function to change the Driver Status

        public void ChangeStatus(string name)
        {
            //Checking if the map contains this username

            if (DriverGlobals.DriverMap.ContainsKey(name))
            {
                //Changing his status

                if (DriverGlobals.DriverMap[name].Status == "0")
                {
                    DriverGlobals.DriverMap[name].Status = "1";

                    //Enqueue that free driver in the FreeDrivers queue
                    DriverGlobals.FreeDrivers.Enqueue(DriverGlobals.DriverMap[name]);
                }
                if (DriverGlobals.DriverMap[name].Status == "1")
                {
                    DriverGlobals.DriverMap[name].Status = "0";
                }
            }
            else
            {
                Console.WriteLine("Username not found.");
            }
        }

        //Recieving a request
        public void RecieveRequest(Driver FreeDriver_, Client Customer)
        {
            DriverTrip TempTrip = new DriverTrip();
            FreeDriver_.ChangeStatus(FreeDriver_.DriverUsername);
            TempTrip.ClientName = Customer.ClientName;
            TempTrip.DriverTripID = Customer.ClientID;
            TempTrip.From = "hakhodha mn textbox";
            TempTrip.To = "hakhodha mn textbox ely taht ely foo'";
            DriverTrip_.Add(FreeDriver_.DriverUsername, TempTrip);
        }

    }
}
