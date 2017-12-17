using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Taxi_Management_System
{
    public class Car
    {
        public static class CarGlobals
        {
            public static Dictionary<string, Car> CarMap = new Dictionary<string, Car>();
        }
        
        string PlateNumber;
        string Color;
        string Year;
        string Model;
        string CarDriverID;
        
        public bool FillCarMap()
        {

            StreamReader Stream = new StreamReader("Clients.txt");

            char[] Delimeters = { ' ', ',', '.', ':', '\t' };
            string Line = Stream.ReadLine();
            Car tempCar = new Car();

            while (Line != null)
            {
                string[] Words = Line.Split(Delimeters);

                tempCar.PlateNumber = Words[0];
                tempCar.Color = Words[1];
                tempCar.Year = Words[2];
                tempCar.Model = Words[3];

                CarGlobals.CarMap[tempCar.PlateNumber] = tempCar;
                
            }
            return true;
        }
    }
}
