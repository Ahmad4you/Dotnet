using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _212_OOP_Print_String_Array_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strNames = { "Ahmad", "Diana", "Leen" };
            PrintStringArray psa = new PrintStringArray(strNames);
            psa.PrintStrArray(";");
        }
    }
}
