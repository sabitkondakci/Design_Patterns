using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.SolidDecorator
{
    class AfterDecoration:CarDecorator
    {
        public AfterDecoration(ICar car) : base(car) { }
        public override double DiscountedPrice() => base.Price * 0.7;
    }
}
