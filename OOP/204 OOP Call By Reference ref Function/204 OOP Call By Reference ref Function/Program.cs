using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _204_OOP_Call_By_Reference_ref_Function
{
    class Program
    {
        static void PrintNum(int num)
        {
            num = 10;
            Console.WriteLine("num in Methode: " + num);
        }
        static void PrintNum2( ref int num)
        {
            num = 10;
            Console.WriteLine("num in Methode: " + num);
        }





        static void Main(string[] args)
        {
            int x = 70;
            Console.WriteLine("x bevor: " + x);
            PrintNum( x);
            Console.WriteLine("x after: " + x);
            PrintNum2( ref x);
            Console.WriteLine("x after ref change: " + x);
        }
    }
}
