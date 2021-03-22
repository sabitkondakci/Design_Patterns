using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{ 
    abstract class Observer
    {
        public double updatedPrice;
        public abstract Task Update(Observable observable);
        public async Task RefreshPrice(double price)
        {
            await Task.Run(() =>
            {
                updatedPrice = price;
            });
        }
    }
}
