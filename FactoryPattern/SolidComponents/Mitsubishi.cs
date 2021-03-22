using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Interfaces;

namespace FactoryPattern.SolidComponents
{
    class Mitsubishi:IVehicle
    {
        public string Model { get; set; } = "L200 Crawler";
        public double Price { get; set; } = 113.4;
    }
}
