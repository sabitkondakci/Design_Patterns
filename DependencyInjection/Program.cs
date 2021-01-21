using System;
using DependencyInjection.Business;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerList list = new CustomerList(ObjectFactory.GetMicrosoftServerObject());
            list.GetCustomers().ForEach(x =>
            {
                Console.WriteLine($"ID:{x.ID,-5} Name:{x.Name,-10}LastPurchaseDate:{x.LastPurchaseDate,-10} ");
            });

            Console.Read();
        }
    }
}
