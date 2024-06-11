using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _228_OOP_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Customer c1 = new Customer();
            Employee e1 = new Employee();
            Doctor d1 = new Doctor();

            Linq.getLinq_geradezahl();
            Console.WriteLine();
            Linq.getLinq_ungeradezahl();
        }
    }
}
