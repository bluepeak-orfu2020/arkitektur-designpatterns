using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternGuess
{
    class Scooter : IVehicle
    {
        public int Wheels { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }


        public static Scooter CreateVehicle(string brand)
        {
            Scooter scooter = new Scooter();
            scooter.Type = "Scooter";
            scooter.Color = "Pink";
            scooter.Wheels = 2;
            scooter.Brand = brand;
            return scooter;
        }
    }
}
