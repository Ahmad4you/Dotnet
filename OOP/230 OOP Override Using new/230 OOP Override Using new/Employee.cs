using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230_OOP_Override_Using_new
{
    class Employee: Person
    {
        public new void PrintTyp()   // overridind with key word "new"
        {
            Console.WriteLine("Employee");
        }
    }
}
