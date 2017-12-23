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
            StreamReader Stream = new StreamReader(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Admin.txt");

            //StreamReader Stream = new StreamReader("Admin.txt");

            char[] Delimeters = { ' ', ',', '.', ':', '\t' };
            string Line = Stream.ReadLine();
            Admin TempAdmin = new Admin();

            while (!string.IsNullOrWhiteSpace(Line))
            {
                string[] Words = Line.Split(Delimeters);

                TempAdmin.AdminName = Words[0];
                TempAdmin.AdminPassword = Words[0];

                AdminGlobals.AdminMap[TempAdmin.AdminName] = TempAdmin;

                Line = Stream.ReadLine();

            }
            return true;
        }

        public void AdminLogin(string uname, string password)
        {
            if (AdminGlobals.AdminMap.ContainsKey(uname))
            {
                if (AdminGlobals.AdminMap[uname].AdminPassword == password)
                {
                    Application.Run(new AdminHome());
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
        public void AddNewDriver (string uname,string password , string name , string driverid , string carid , string salary , string status)
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
            DriverGlobals.NewDrivers[uname] = tempdriver;
        }

        public void AddNewCar(string PlateNumber, string Color, string Year, string Model)
        {
            Car TempCar = new Car();
            TempCar.PlateNumber = PlateNumber;
            TempCar.Color = Color;
            TempCar.Year = Year;
            TempCar.Model = Model;
            Car.CarGlobals.CarMap[PlateNumber] = TempCar;
            Car.CarGlobals.NewCars[PlateNumber] = TempCar;
        }

        //Di l function ely bt ADD fel text file -Drivers-
        public void UpdateDriverFile(string DriverUsername, string DriverPassword, string DriverName, string CarID, string Salary, string Status)
        {
            if (!string.IsNullOrEmpty(DriverUsername) && !string.IsNullOrEmpty(DriverPassword)
                && !string.IsNullOrEmpty(DriverName) && !string.IsNullOrEmpty(CarID) && !string.IsNullOrEmpty(Salary) && !string.IsNullOrEmpty(Status))
            {
                using (StreamWriter writer = new StreamWriter("Drivers.txt", true))
                {
                    writer.WriteLine(DriverUsername + " ");
                    writer.Write(DriverPassword + " ");
                    writer.Write(DriverName + " ");
                    writer.Write(CarID + " ");
                    writer.Write(Salary + " ");
                    writer.Write(Status + " ");
                    MessageBox.Show("Driver has been added successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please fill the empty text boxes!");

            }
        }

        //De l function ely bt ADD fel file -Cars-
        public void UpdateCarFile(string PlateNumber, string Color, string Year, string Model)
        {
            if (!string.IsNullOrEmpty(PlateNumber) && !string.IsNullOrEmpty(Color)
                && !string.IsNullOrEmpty(Year) && !string.IsNullOrEmpty(Model))
            {
                using (StreamWriter writer = new StreamWriter("Cars.txt", true))
                {
                    writer.Write(PlateNumber + " ");
                    writer.Write(Color + " ");
                    writer.Write(Year + " ");
                    writer.WriteLine(Model);
                    MessageBox.Show("car has been added successfully");
                }
            }
            else
            {
                MessageBox.Show("Please fill the empty text boxes");
            }
        }
    }
}