using System;
using ObserverPattern.Abstracts;
using ObserverPattern.Observables;
using ObserverPattern.Observers;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Observable stockControl = new StockControl();
            Observer electronicShelfLabel = new ElectronicShelfLabel();
            Observer managerDesktopDisplay = new ManagerDesktopDisplay();

            stockControl.AddAsync(electronicShelfLabel);
            stockControl.AddAsync(managerDesktopDisplay);

            stockControl.RefreshPrice(11).GetAwaiter().GetResult();
            stockControl.NotifyAsync().GetAwaiter().GetResult();

            Console.WriteLine("--- Before Update ---");
            Console.WriteLine(electronicShelfLabel.updatedPrice);
            Console.WriteLine(managerDesktopDisplay.updatedPrice);


            stockControl.RefreshPrice(25).GetAwaiter().GetResult();
            stockControl.RemoveAsync(managerDesktopDisplay).GetAwaiter().GetResult();
            stockControl.NotifyAsync().GetAwaiter().GetResult();

            Console.WriteLine("--- After Update ---");
            Console.WriteLine(electronicShelfLabel.updatedPrice);
            Console.WriteLine(managerDesktopDisplay.updatedPrice);



        }
    }
}
