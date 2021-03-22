using System;
using FactoryPattern.Factories;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = VehicleFactory.Create(Vehicles.Mercedes);
            IAnimal animal = AnimalFactory.Create(Animals.Raven);

            Console.WriteLine(vehicle.Model);
            Console.WriteLine(vehicle.Price);

            animal.AnimalFamily();
            animal.AnimalSound();
        }
    }
}
