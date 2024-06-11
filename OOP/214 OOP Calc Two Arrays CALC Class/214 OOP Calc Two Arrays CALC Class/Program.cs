using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_OOP_Calc_Two_Arrays_CALC_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i1 = { 1, 2, 3 };
            int[] i2 = { 4, 5, 6 };
            Calc cCalc = new Calc();
            cCalc.PrintCalcTwoArrays(i1, i2, '+');
            Console.WriteLine();
            cCalc.PrintCalcTwoArrays(i1, i2, '*');
        }
    }
}
