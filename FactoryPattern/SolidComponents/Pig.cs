using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Interfaces;

namespace FactoryPattern.SolidComponents
{
    class Pig:IAnimal
    {
        public void AnimalSound()
        {
            // sound
            Console.WriteLine("hwwwrrrr");
        }

        public void AnimalFamily()
        {
            // family
            Console.WriteLine("even-toed ungulate family");
        }
    }
}
