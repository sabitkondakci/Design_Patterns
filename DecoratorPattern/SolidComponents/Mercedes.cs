using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.SolidComponents
{
    // sealed to prevent modification
    sealed class Mercedes:ICar
    {
        public double Price => 33.421;
        public string Model => "Benz W115";
    }
}
