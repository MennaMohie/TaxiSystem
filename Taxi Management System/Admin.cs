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
    public class Admin
    {
        public static class AdminGlobals
        {
            public static Dictionary<string, Admin> AdminMap = new Dictionary<string, Admin>();
        }
        public List<Trip> AllTrips = new List<Trip>();

       

        string AdminName;
        string AdminPassword;

        public bool FillAdminMap()
        {
            //Awad
            StreamReader Stream = new StreamReader(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Admin.txt");

            //mohie
            //StreamReader Stream = new StreamReader(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Admin.txt");

            //StreamReader Stream = new StreamReader("Admin.txt");

            char[] Delimeters = { ' ', ',', '.', ':', '\t' };
            string Line = Stream.ReadLine();
            Admin TempAdmin = new Admin();

            while (!string.IsNullOrWhiteSpace(Line))
            {
                string[] Words = Line.Split(Delimeters);

                TempAdmin.AdminName = Words[0];
                TempAdmin.AdminPassword = Words[1];

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
                    Login.isAdmin = true;
                    Login.notregisterd = false;

                }
                else
                {
                    Login.notregisterd = false;
                    MessageBox.Show("Either username or password is incorrent, please try again.");
                }
            }
            
            
        }

        public void SendTripData(Trip Trip)
        {
            AllTrips.Add(Trip);
        }
        public void AddNewCar(string PlateNumber, string Color, string Year, string Model)
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


        public void viewtrips ()
        {
            int num_trips;
            num_trips = AllTrips.Count;
            DataTable Trips = new DataTable();
            Trips.Columns.Add("Client Name");
            Trips.Columns.Add("Driver Name");
            Trips.Columns.Add("From");
            Trips.Columns.Add("To");
            Trips.Columns.Add("Date");

            DataRow NewTrip;
            for (int i = 0; i < num_trips; i++)
            {
                NewTrip = Trips.NewRow();
                NewTrip["Client Name"] = AllTrips[i].ClientName;
                NewTrip["Driver Name"] = AllTrips[i].DriverName;
                NewTrip["From"] = AllTrips[i].From;
                NewTrip["To"] = AllTrips[i].To;
                NewTrip["Date"] = AllTrips[i].Date;
                Trips.Rows.Add(NewTrip);
            }
            DGV.DataSource = Trips;

            
        }
        public void addnewdriver (string uname,string password , string name , string driverid , string carid , string salary , string status)
        {
            Driver tempdriver=new Driver();
            tempdriver.DriverUsername = uname;
            tempdriver.DriverPassword = password;
            tempdriver.DriverName = name;
            tempdriver.DriverID = driverid;
            tempdriver.CarID = carplatenumber;
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