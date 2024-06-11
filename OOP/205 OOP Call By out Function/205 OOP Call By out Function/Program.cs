using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205_OOP_Call_By_out_Function
{
   
    class Program
    {
        static void PrintName(out string strName)
        {
            strName = "Ahmad";
            Console.WriteLine("Hallo: " + strName);
        }
        static void Main(string[] args)
        {
            string myName;    // hier we don't have any assignment just Variable don't have assignment
            PrintName(out myName);
        }
    }
}
