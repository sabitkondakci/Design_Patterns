using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Decorator
{
    public abstract class CarDecorator:ICar
    {
        private readonly ICar _car;

        protected CarDecorator(ICar car)
        {
            this._car = car;
        }

        public double Price => _car.Price;
        public string Model => _car.Model;

        public abstract double DiscountedPrice();
    }
}
