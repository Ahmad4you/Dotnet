using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _234_OOP_constructor_inherited_class_with_base
{
    class Person
    {
        public Person(string type = "Person")
        {
            Console.WriteLine("New() " + type);
        }

        //public Person(bool IsRun = true)
        //{
        //    if (IsRun)
        //    {
        //        Console.WriteLine("---------------");
        //        Console.WriteLine("New() Person");
        //        Console.WriteLine("---------------");
        //    }
            
        //}
    }
}
