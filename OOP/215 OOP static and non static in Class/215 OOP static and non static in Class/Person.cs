using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215_OOP_static_and_non_static_in_Class
{
    class Person
    {
        public static int id;
        public static string name;
        public static string adress;

        public static void PrintData()
        {
            Console.WriteLine(id + ";" + name + ";" + adress);
        }
        public static void PrintNameAndAdress()
        {
            Console.WriteLine(name + ";" + adress);
        }

    }
}
