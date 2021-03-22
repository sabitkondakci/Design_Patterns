using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Interfaces
{
    interface IVehicle
    {
        string Model { get; set; }
        double Price { get; set; }

    }
}
