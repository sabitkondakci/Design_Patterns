using System;
using CompositePattern.Composites;
using CompositePattern.Leaves;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IStaff Elif = new Employee("Elif", "HR");
            IStaff Canan = new Employee("Canan", "IT");
            IStaff Emin = new Employee("Emin", "FR");
            IStaff Kadir = new Employee("Kadir", "AC");

            IStaff Gamze = new Manager("Gamze", "IT"){subOrdinates = {Canan,Kadir}};
            IStaff Julia = new Manager("Julia", "HR"){subOrdinates = {Elif,Emin}};

            Elif.Details();

            Console.WriteLine();
        }
    }
}
