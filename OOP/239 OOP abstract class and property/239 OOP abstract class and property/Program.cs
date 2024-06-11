using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _239_OOP_abstract_class_and_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.address = "Ulm";
            e. Name = "Ahmad"; // setter value
            e.PrintData();
            Console.WriteLine("name getter: " + e.Name);
        }
    }
}
