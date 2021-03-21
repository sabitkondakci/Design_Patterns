using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public interface ICar
    {
        double Price { get; }
        string Model { get; }
    }
}
