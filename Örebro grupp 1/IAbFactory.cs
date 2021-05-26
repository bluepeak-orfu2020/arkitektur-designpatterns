using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternGuess
{
    interface IAbFactory
    {
        IVehicle CreateVehicle(string brand);
    }

    class CarFactory : IAbFactory
    {
        public IVehicle CreateVehicle(string brand)
        {
            Car car = new Car();
            car.Type = "Car";
            car.Color = "Black";
            car.Wheels = 4;
            car.Brand = brand;
            return car;
        }
    }
    
    class MotorcycleFactory : IAbFactory
    {
        public IVehicle CreateVehicle(string brand)
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Type = "Motorcycle";
            motorcycle.Color = "Red";
            motorcycle.Wheels = 2;
            motorcycle.Brand = brand;
            return motorcycle;
        }
    }
    
    class ScooterFactory : IAbFactory
    {
        public IVehicle CreateVehicle(string brand)
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
