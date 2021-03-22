using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Interfaces;
using FactoryPattern.SolidComponents;

namespace FactoryPattern.Factories
{
    public enum Animals
    {
        Pig,
        Raven
    };
     struct AnimalFactory
    {
        public static IAnimal Create(Animals animal)
        {
            switch (animal)
            {
                case Animals.Pig:
                    return new Pig();
                case Animals.Raven:
                    return new Raven();
                default:
                    return null;
            }
        }
    }
}
