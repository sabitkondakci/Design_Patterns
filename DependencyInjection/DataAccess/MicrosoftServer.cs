using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjection.Abstract;

namespace DependencyInjection.DataAccess
{
    class MicrosoftServer:IDataAccessLayer
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){ID = 1,LastPurchaseDate = DateTime.Today,Name = "Trio"},
                new Customer(){ID = 2,LastPurchaseDate = DateTime.Today,Name = "Feyza"}
            };
        }
    }
}
