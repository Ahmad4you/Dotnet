using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _229_OOP_Overloading_and_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Ahnad";
            p1.Phone = "012367899766";
            p1.Adress = "Stuttgart";

            string str = p1.GetPersonData(" %%% ");     // this has 2 usage
            Console.WriteLine(str);
            Console.WriteLine(p1.GetPersonData(" || ", " this is a Person Data"));

            Student std1 = new Student(1, "Omar");
            //std1.id = 1;
            //std1.name = "Omar";
            std1.PrintData();
            Student std2 = new Student();
            std2.PrintData();
        }
    }
}
