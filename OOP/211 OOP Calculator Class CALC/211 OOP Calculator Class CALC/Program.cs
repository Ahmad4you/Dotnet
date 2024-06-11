using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211_OOP_Calculator_Class_CALC
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c1 = new Calc(7, 3);
            c1.PrintAdd();
            c1.PrintMulti();
            c1.PrintSub();
            c1.PrintDiv();
            c1.PrintModulo();
        }
    }
}
