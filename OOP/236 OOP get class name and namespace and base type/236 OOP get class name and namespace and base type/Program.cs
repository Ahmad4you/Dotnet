using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _236_OOP_get_class_name_and_namespace_and_base_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Person p1 = new Person();
            Customer c1 = new Customer();
            Employee e1 = new Employee();
            Doctor d1 = new Doctor();

            Console.WriteLine(s1.GetType().Name);
            Console.WriteLine(s1.GetType().Namespace);
            Console.WriteLine(s1.GetType().FullName);
            Console.WriteLine(s1.GetType().BaseType); // from object vererbt
            Customer c2 = new Customer();
            Console.WriteLine(c2.GetType().BaseType); // from Person vererbt

            //StreamWriter sw = new StreamWriter("File.txt");
            //Console.WriteLine(sw.GetType().FullName);
        }
    }
}
