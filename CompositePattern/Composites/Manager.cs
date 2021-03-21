using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Composites
{
    class Manager:IStaff
    {
        private Guid Id { get; set; }
        protected string Name { get; set; }
        protected string Department { get; set; }
        public List<IStaff> subOrdinates;
        
        public Manager(string name, string department)
        {
            this.Name = name;
            this.Department = department;
            this.Id = Guid.NewGuid();
            this.subOrdinates = new List<IStaff>();
        }
        public void Details()
        {
            Console.WriteLine(" ------- Manager ------- ");
            Console.WriteLine($"Name: {Name} \nDepartment:{Department}\nId:{Id}\n");
            Console.WriteLine(" ------- ResponsibleFor -------");
            foreach (var staff in subOrdinates)
            {
                staff.Details();
            }
        }
    }
}
