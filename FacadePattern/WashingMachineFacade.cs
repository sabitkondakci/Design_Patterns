using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.WashingMachineFacade
{
    class WashingMachine
    {
        private readonly WashingMachineManualBar _menuBar;
        private readonly WashingMachineTouchScreen _touchScreen;

        public WashingMachine(bool cottons, bool allergyPlus
            , bool wool, bool mix, bool easyCare,
            bool drain, int temperature, 
            int rpm, bool extraDry, bool smooth)
        {
            this._menuBar = new WashingMachineManualBar( cottons,  allergyPlus
                ,  wool,  mix,  easyCare,  drain);
            this._touchScreen = new WashingMachineTouchScreen( temperature,  rpm,  extraDry,  smooth);
        }

        public void StartWashing()
        {
            Console.WriteLine("Machine Started!");
            _menuBar.ConfigureMenuBar();
            _touchScreen.ConfigureTouchScreen();
        }

        public void StopWashing()
        {
            Console.WriteLine("Machine Stopped");
        }

    }
}
