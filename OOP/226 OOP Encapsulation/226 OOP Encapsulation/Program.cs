using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226_OOP_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Id = 1111;
            e.Name = "Ahmad";
            e.Salary = 2000;         // 2000 will in value gespeichert, u will chang the value
                                     // u must if-statement bevor value addieren
            e.PrintData();
            
        }
    }
}
