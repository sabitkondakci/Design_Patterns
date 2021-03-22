using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Observables
{
    class StockControl : Observable
    {
        public override async Task<double> UpdatedPriceAsync()
        {
            return await Task.Run(() => updatedPrice);
        }
        public StockControl():base() { }
        public override async Task AddAsync(Observer observer)
        {
            await Task.Run(() =>
            {
                observerList.Add(observer);
            });
        }

        public override async Task NotifyAsync()
        {
            await Task.Run(() =>
            {
                foreach (var observer in observerList)
                {
                    observer.Update(this);
                }
            });
        }

        public override async Task RemoveAsync(Observer observer)
        {
            await Task.Run(() =>
            {
                observerList.Remove(observer);
            });
        }
    }
}
