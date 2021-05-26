using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternGuess
{
    class Car : IVehicle
    {
        public int Wheels { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }


        public static Car CreateVehicle(string brand)
        {
            Car car = new Car();
            car.Type = "Car";
            car.Color = "Black";
            car.Wheels = 4;
            car.Brand = brand;
            return car;
        }
    }
}
