using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class WashingMachineTouchScreen
    {
        private readonly int _temperature;
        private readonly int _rpm;
        private readonly bool _extraDry;
        private readonly bool _smooth;
        public WashingMachineTouchScreen(int temperature, int rpm,bool extraDry,bool smooth)
        {
            this._temperature = temperature;
            this._rpm = rpm;
            this._extraDry = extraDry;
            this._smooth = smooth;
        }

        public void ConfigureTouchScreen()
        {
            Console.WriteLine($"Temperature:{_temperature} RPM:{_rpm} ExtraDry:{_extraDry} Smooth:{_smooth}");
        }
    }
}
