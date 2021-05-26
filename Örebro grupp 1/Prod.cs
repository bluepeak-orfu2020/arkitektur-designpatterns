using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternGuess
{
    class Prod
    {
        private IAbFactory GetFactory(string type)
        {
            if (type == "car")
            {
                return new CarFactory();
            }
            else if (type == "motorcycle")
            {
                return new MotorcycleFactory();
            }
            else if (type == "scooter")
            {
                return new ScooterFactory();
            }
            else
            {
                throw new Exception("we dont make that type of vehicle(car, motorcycle, scooter)");
            }
        }
        
        public IVehicle Production(string type, string brand)
        {
            IAbFactory factory = GetFactory(type);
            return factory.CreateVehicle(brand);
        }
    }
}
