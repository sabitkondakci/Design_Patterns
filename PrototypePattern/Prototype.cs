using System;
using System.Runtime.CompilerServices;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new Test { Name = "Ahmet", Surname = "Yesevi", Age = 11, City = "Malatya" };
            var second = first.ShallowCopy;

            first.Name = "#";
            Console.WriteLine(second.Name);

            Console.WriteLine(first.GetHashCode());
            Console.WriteLine(second.GetHashCode());       
        }
    }

    class Test
    {
        public Test()
        {
            AddressInfo = new Address();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Address AddressInfo { get; set; }
        public Test ShallowCopy => this.MemberwiseClone() as Test; //copy of non-static fields
        
        public Test DeepCopy()
        {
            var clone = (Test) MemberwiseClone();
            clone.AddressInfo = new Address();
            return clone;
        }

    }

    public class Address
    {
        public Address(int doorNumber=0, int streetNumber=0,
            int zipCode=100, string country="Nowhere")
        {
            this.Country = country;
            this.DoorNumber = doorNumber;
            this.StreetNumber = streetNumber;
            this.Zipcode = zipCode;
        }

        public int DoorNumber { get; set; }
        public int StreetNumber { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
    }
}
