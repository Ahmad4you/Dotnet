using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210_OOP_Constructor_With_Parameters_in_Class
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("Construktor wird mal augerufen");
        }
        public void SichtbarMethode()
        {
            Console.WriteLine("das ist eine Sichtbare Methode, gegenteil Construktor!!");
        }
    }
}
