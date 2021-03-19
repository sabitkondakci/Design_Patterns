using System;
using System.Text.Json.Serialization;
using AdapterPattern.Adapter;
using AdapterPattern.Target;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer customerJson = new CustomerAdapter(); //CustomerManager implements ICustomer , polymorphism!
            string result = customerJson.GetCustomerList();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
