using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_Management_System
{
    public class Car
    {
        public static class CarGlobals
        {
            public static Dictionary<string, Car> CarMap = new Dictionary<string, Car>();
        }

        public bool FillCarMap()
        {
            return true;
        }
    }
}
