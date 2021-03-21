using System;
using DecoratorPattern.Decorator;
using DecoratorPattern.SolidComponents;
using DecoratorPattern.SolidDecorator;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Mercedes();
            CarDecorator decorator = new AfterDecoration(car);

            Console.WriteLine($"Name:{car.GetType().Name}\nModel:{decorator.Model}\nPrice:{decorator.Price}\nOff-Price:{decorator.DiscountedPrice()}");
        }
    }
}
