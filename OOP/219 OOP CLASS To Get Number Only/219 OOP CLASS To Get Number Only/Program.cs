using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219_OOP_CLASS_To_Get_Number_Only
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "sd3l5m1dsfsd9fdgd0";
            int i = Tools.GetNumberOnly(str);
            Console.WriteLine(i);

            Tools.PrintNumberOnly(str);
        }
    }
}
