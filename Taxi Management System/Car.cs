using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Taxi_Management_System
{
    public static class CarGlobals
    {
        public static Dictionary<string, Car> CarMap = new Dictionary<string, Car>();
        public static Dictionary<string, Car> NewCars = new Dictionary<string, Car>();
    }

    public class Car
    {
        public string PlateNumber;
        public string Color;
        public string Year;
        public string Model;
        
        
        public bool FillCarMap()
        {

            StreamReader Stream = new StreamReader(@"C:\Users\Menna\Source\Repos\TaxiSystem\Taxi Management System\Text Files\Cars.txt");

            //StreamReader Stream = new StreamReader("Cars.txt");

            char[] Delimeters = { ' ', ',', '.', ':', '\t' };
            string Line = Stream.ReadLine();
            Car tempCar = new Car();

            while (!string.IsNullOrWhiteSpace(Line))
            {
                string[] Words = Line.Split(Delimeters);

                tempCar.PlateNumber = Words[0];
                tempCar.Color = Words[1];
                tempCar.Year = Words[2];
                tempCar.Model = Words[3];

                CarGlobals.CarMap[tempCar.PlateNumber] = tempCar;
                Line = Stream.ReadLine();

            }
            return true;
        }
    }
}
