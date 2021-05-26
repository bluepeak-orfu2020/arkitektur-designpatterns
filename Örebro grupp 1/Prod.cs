using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternGuess
{
    class Prod
    {
        
        public IVehicle Production(string type, string brand)
        {
            if (type == "car")
            {
                return Car.CreateVehicle(brand);
            }
            else if (type == "motorcycle")
            {
                return Motorcycle.CreateVehicle(brand);
            }
            else if (type == "scooter")
            {
                return Scooter.CreateVehicle(brand);
            }
            else
            {
                throw new Exception("we dont make that type of vehicle(car, motorcycle, scooter)");
            }
        }
    }
}
