using System;
using System.Threading;
using FacadePattern.WashingMachineFacade;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new WashingMachine(true, false, false, false, false, false, 40, 1200, true, true);
            machine.StartWashing();

            Thread.Sleep(5000);
            machine.StopWashing();

            Console.Read();
        }
    }
}
