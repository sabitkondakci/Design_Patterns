using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Abstract
{
    interface IDataAccessLayer
    {
        List<Customer> GetCustomers();
    }
}
