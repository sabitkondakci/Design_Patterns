using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Leaves
{
    class Employee:IStaff
    {
        private Guid Id { get; set; }
        protected string Name { get; set; } 
        protected string Department { get; set; }
        public Employee(string name, string department)
        {
            this.Name = name;
            this.Department = department;
            this.Id = Guid.NewGuid();
        }
        public void Details()
        {
            Console.WriteLine($"Name: {Name} \nDepartment:{Department}\nId:{Id}\n");
        }
    }
}
