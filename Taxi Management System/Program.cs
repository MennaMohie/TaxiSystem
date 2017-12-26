using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Taxi_Management_System
{
    static class Program
    { 
        public static Client client = new Client();
        public static Driver driver = new Driver();
        public static Car car = new Car();
        public static Admin admin = new Admin();

        [STAThread]
        static void Main()
        {
            ClientGlobals.ClientMap.Clear();
            DriverGlobals.DriverMap.Clear();
            CarGlobals.CarMap.Clear();
            AdminGlobals.AdminMap.Clear();

            client.FillCientMap();
            driver.FillDriverMap();
            car.FillCarMap();
            admin.FillAdminMap();
            admin.FillTripsList();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Register());

        }

        public static void updateFiles()
        {
            updateDriversFile();
            updateCarsFile();
            updateClientsFile();
            updateTripsFile();
        }

        static void updateDriversFile()
        {
            //using (StreamWriter writer = new StreamWriter("Drivers.txt", true))
            using (StreamWriter Writer = new StreamWriter(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Drivers.txt", false))
            {
                foreach (KeyValuePair<string, Driver> KVP in DriverGlobals.DriverMap)
                {
                    Writer.Write(KVP.Value.DriverUsername + ' ');
                    Writer.Write(KVP.Value.DriverPassword + ' ');
                    Writer.Write(KVP.Value.DriverName + ' ');
                    Writer.Write(KVP.Value.DriverID + ' ');
                    Writer.Write(KVP.Value.Salary + ' ');
                    Writer.Write(KVP.Value.Status + Environment.NewLine);
                }
                Writer.Close();
            }            
        }
        
        static void updateCarsFile()
        {
            //using (StreamWriter writer = new StreamWriter("Cars.txt", true))
            using (StreamWriter Writer = new StreamWriter(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Cars.txt", true))
            {
                foreach (KeyValuePair<string, Car> KVP in CarGlobals.NewCars)
                {
                    Writer.Write('\n' + KVP.Value.PlateNumber + ' ');
                    Writer.Write(KVP.Value.Color + ' ');
                    Writer.Write(KVP.Value.Year + ' ');
                    Writer.Write(KVP.Value.Model + ' ');
                }
                Writer.Close();
            }
        }

        static void updateClientsFile()
        {
            //using (StreamWriter writer = new StreamWriter("Clients.txt", true))
            using (StreamWriter Writer = new StreamWriter(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Clients.txt", true))
            {
                foreach (KeyValuePair<string, Client> KVP in ClientGlobals.NewClients)
                {
                    Writer.Write('\n' + KVP.Value.ClientUsername + ' ');
                    Writer.Write(KVP.Value.ClientName + ' ');
                    Writer.Write(KVP.Value.ClientID + ' ');
                    Writer.Write(KVP.Value.ClientPassword + Environment.NewLine);
                }
                Writer.Close();
            }
        }

        static void updateTripsFile()
        {
            using (StreamWriter Writer = new StreamWriter(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Trips.txt", false))
            {
                foreach(Trip trip in AdminGlobals.AllTrips)
                {
                    Writer.Write(trip.ClientUsername + ' ');        
                    Writer.Write(trip.DriverUserName + ' ');
                    Writer.Write(trip.From + ' ');
                    Writer.Write(trip.To + ' ');
                    Writer.Write(trip.Date.ToString() + ' ');
                    Writer.Write(trip.Status + Environment.NewLine);
                }
            }
        }
    }
}
