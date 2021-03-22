using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Observers
{
    class ElectronicShelfLabel:Observer
    {
        public override async Task Update(Observable stockControl)
        {
           updatedPrice = await stockControl.UpdatedPriceAsync();
        }
    }

}
