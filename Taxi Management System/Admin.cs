using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace Taxi_Management_System
{
    public static class AdminGlobals
    {
        public static Dictionary<string, Admin> AdminMap = new Dictionary<string, Admin>();
        public static List<Trip> AllTrips = new List<Trip>();
    }

    public class Admin
    {
        public string AdminUsername;
        public string AdminPassword;

        public void FillAdminMap()
        {
            //Awad
            //StreamReader Stream = new StreamReader(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Admin.txt");

            //mohie
            StreamReader Stream = new StreamReader(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Admin.txt");

            //Eman
            //StreamReader Stream = new StreamReader(@"C:\Users\Eman\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Admin.txt");

            //StreamReader Stream = new StreamReader("Admin.txt");

            char[] Delimeters = { ' ', ',', '.', ':', '\t' };
            string Line = Stream.ReadLine();

            while (!string.IsNullOrWhiteSpace(Line))
            {
                Admin TempAdmin = new Admin();
                string[] Words = Line.Split(Delimeters);

                TempAdmin.AdminUsername = Words[0];
                TempAdmin.AdminPassword = Words[1];

                AdminGlobals.AdminMap[TempAdmin.AdminUsername] = TempAdmin;

                Line = Stream.ReadLine();
            }

            Stream.Close();
        }

        public void FillTripsList()
        {
            //mohie
            StreamReader Stream = new StreamReader(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Trips.txt");

            char[] Delimeters = {' '};
            string Line = Stream.ReadLine();
            while (!string.IsNullOrWhiteSpace(Line))
            {
                Trip tempTrip = new Trip();
                string[] Words = Line.Split(Delimeters);

                
                tempTrip.ClientUsername = Words[0];
                tempTrip.ClientName = ClientGlobals.ClientMap[tempTrip.ClientUsername].ClientName;
                tempTrip.DriverUserName = Words[1];
                tempTrip.DriverName = DriverGlobals.DriverMap[tempTrip.DriverUserName].DriverName;
                tempTrip.From = Words[2];
                tempTrip.To = Words[3];
                tempTrip.Date = Words[4] + ' ' + Words[5] + ' ' + Words[6];
                tempTrip.Status = Words[7];

                AdminGlobals.AllTrips.Add(tempTrip);

                Line = Stream.ReadLine();
            }

            Stream.Close();
        }

        public void SendTripData(Trip Trip)
        {
            AdminGlobals.AllTrips.Add(Trip);
        }

       
        public void AddNewDriver(string uname, string password, string name, string driverid, string carplatenumber, string salary, string status)
        {
            Driver tempdriver = new Driver();
            tempdriver.DriverUsername = uname;
            tempdriver.DriverPassword = password;
            tempdriver.DriverName = name;
            tempdriver.DriverID = driverid;
            tempdriver.CarID = carplatenumber;
            tempdriver.Salary = salary;
            tempdriver.Status = status;
            DriverGlobals.DriverMap[uname] = tempdriver;
        }

        public void AddNewCar(string PlateNumber, string Color, string Year, string Model)
        {
            Car TempCar = new Car();
            TempCar.PlateNumber = PlateNumber;
            TempCar.Color = Color;
            TempCar.Year = Year;
            TempCar.Model = Model;
            CarGlobals.CarMap[PlateNumber] = TempCar;
            CarGlobals.NewCars[PlateNumber] = TempCar;
        }
    }
}