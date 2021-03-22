using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Abstracts
{
    abstract class  Observable
    {
        protected List<Observer> observerList;

        protected double updatedPrice;
        protected Observable()
        {
            this.observerList = new List<Observer>();
        }
        public abstract Task AddAsync(Observer observer);
        public abstract Task RemoveAsync(Observer observer);
        public abstract Task NotifyAsync();
        public abstract Task<double> UpdatedPriceAsync();
        public async Task RefreshPrice(double price)
        {
            await Task.Run(() =>
            {
                updatedPrice = price;
            });
        }
    }
}
