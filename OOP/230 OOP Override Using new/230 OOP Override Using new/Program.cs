using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230_OOP_Override_Using_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Employee e1 = new Employee();
            Customer c1 = new Customer();
            Doctor d1 = new Doctor();

            p1.PrintTyp();
            e1.PrintTyp();
            c1.PrintTyp();
            d1.PrintTyp();

            Person p2 = new Doctor();      // with override ++++++++
            Person p3 = new Employee();    // with new

            object o1 = "Hallo";
            object o2 = 111;
            object o3 = 1.5;
            object o4 = 'S';
            object o5 = true;
            object o6 = new Person();  // all in C# come from Class object
            
            Console.WriteLine();
            p2.PrintTyp();
            p3.PrintTyp();
        }
    }
}
