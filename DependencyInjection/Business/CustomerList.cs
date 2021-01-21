using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjection.Abstract;

namespace DependencyInjection.Business
{
    class CustomerList
    {
        private static IDataAccessLayer _dataAccessLayer;

        public CustomerList(IDataAccessLayer dataAccessLayer)
        {
            _dataAccessLayer = dataAccessLayer;
        }

        public List<Customer> GetCustomers() => _dataAccessLayer.GetCustomers();
    }
}
