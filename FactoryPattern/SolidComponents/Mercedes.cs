using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Interfaces;

namespace FactoryPattern.SolidComponents
{
    class Mercedes:IVehicle
    {
        public string Model { get; set; } = "Benz W115";
        public double Price { get; set; } = 55.5;
    }
}
