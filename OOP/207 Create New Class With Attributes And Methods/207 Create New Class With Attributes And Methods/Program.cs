using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _207_Create_New_Class_With_Attributes_And_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.id = 01;
            e.name = "Ahmad";
            e.phone = "0143 645 6657";
            e.salary = 5000;
            e.address = "sdf";

            e.PrintEmployeeData();
        }
    }
}
