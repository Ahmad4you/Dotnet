using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215_OOP_static_and_non_static_in_Class
{
    class Program
    {
        public void printMyName()
        {
            Console.WriteLine("Ahmad");
        }
        public static void printMyName2()
        {
            Console.WriteLine("Diana");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.printMyName();
            printMyName2();

            Person.id = 001;
            Person.name = "Ahmad";
            Person.adress = "Ulm";

            Person.id = 011;

            Person.PrintData();
        }
    }
}
