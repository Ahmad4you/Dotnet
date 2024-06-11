using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060_Debuging_TRACING_PROGRAM
{
    class Program
    {
        static void Main(string[] args) // press F5 to start debuging + F11
        {
            string[] strNames = { "Ahmad", "Diana", "Leen" };

            for(int x = 0; x <= 3; x++)
            {
                Console.WriteLine(strNames[x]);
            }
        }
    }
}
