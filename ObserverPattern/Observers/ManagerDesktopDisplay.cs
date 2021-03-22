using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Observers
{
    class ManagerDesktopDisplay : Observer
    {
        public override async Task Update(Observable stockControl)
        {
            updatedPrice = await stockControl.UpdatedPriceAsync();
        }
    }
}
