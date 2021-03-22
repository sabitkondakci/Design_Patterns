using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Interfaces;
using FactoryPattern.SolidComponents;

namespace FactoryPattern.Factories
{
    public enum Vehicles
    {
        Mitsubishi,
        Mercedes
    };
    struct VehicleFactory
    {
        public static IVehicle Create(Vehicles vehicle)
        {
            switch (vehicle)
            {
                case Vehicles.Mitsubishi:
                    return new Mitsubishi();
                case Vehicles.Mercedes:
                    return new Mercedes();
                default:
                    return null;
            }
        }
    }
}
