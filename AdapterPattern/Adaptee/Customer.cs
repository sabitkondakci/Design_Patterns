using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace AdapterPattern.Adaptee
{
    [Serializable]
    public class Customer
    {
        [XmlAttribute]
        private int Id { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Surname { get; set; }
        [XmlAttribute]
        public string Email { get; set; }
        public Customer() { }
        public Customer(int id,string name,string surname,string email)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
        }
    }

    public class CustomerManager:ICustomer
    {
        public List<Customer> customers;

        public CustomerManager()
        {
            customers = new List<Customer>
            {
                new Customer(1, "Ali", "Tok", "kurnaz@gmail.com"),
                new Customer(2, "Feraye", "Kaya", "ferkaya@gmail.com")
            };
        }

        // for flexibility purpose transformable methods should be virtual in order for them to be overriden .
        public virtual string GetCustomerList()
        {
            var emptyNamespace = new XmlSerializerNamespaces(new[] {XmlQualifiedName.Empty});
            var serialize = new XmlSerializer(customers.GetType());
            var settings = new XmlWriterSettings(){Indent = true,OmitXmlDeclaration = true};

            using var stream = new StringWriter();
            using var writer = XmlWriter.Create(stream,settings);

            serialize.Serialize(writer,customers,emptyNamespace);
            return stream.ToString();
        }
    }
}
