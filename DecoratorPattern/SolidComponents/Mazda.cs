using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.SolidComponents
{
    // sealed to prevent modification
    sealed class Mazda:ICar
    {
        public double Price => 154.334;
        public string Model => "MX-5 Z-Sport";
    }
}
