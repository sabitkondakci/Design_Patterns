using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class WashingMachineManualBar
    {
        private readonly bool _cottons;
        private readonly bool _allergyPlus;
        private readonly bool _wool;
        private readonly bool _mix;
        private readonly bool _easyCare;
        private readonly bool _drain;
        public WashingMachineManualBar(bool cottons,bool allergyPlus
            ,bool wool,bool mix,bool easyCare,bool drain)
        {
            this._cottons = cottons;
            this._allergyPlus = allergyPlus;
            this._wool = wool;
            this._mix = mix;
            this._easyCare = easyCare;
            this._drain = drain;
        }

        public void ConfigureMenuBar()
        {
            Console.WriteLine($"Cottons: {_cottons} AllergyPlus: {_allergyPlus} Wool:{_wool} Mix{_mix} EasyCare:{_easyCare} Drain:{_drain}");
        }
    }
}
