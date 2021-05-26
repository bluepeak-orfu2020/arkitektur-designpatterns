using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternGuess
{
    class Motorcycle : IVehicle
    {
        public int Wheels { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public static Motorcycle CreateVehicle(string brand) 
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Type = "Motorcycle";
            motorcycle.Color = "Red";
            motorcycle.Wheels = 2;
            motorcycle.Brand = brand;
            return motorcycle;
        }

    }
}
