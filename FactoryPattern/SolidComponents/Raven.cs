using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Interfaces;

namespace FactoryPattern.SolidComponents
{
    class Raven:IAnimal
    {
        public void AnimalSound()
        {
            // sound properties
            Console.WriteLine("crawl");
        }

        public void AnimalFamily()
        {
            // family specifications
            Console.WriteLine("bird");
        }
    }
}
