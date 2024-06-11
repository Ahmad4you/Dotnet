using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _068_REPLACE_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            string strText = "Software und&Treiber für HP , ZBook&Studio G3 Mobile$Workstation (Basismodell)";
            string strText2 = strText.Replace(" (", "(").Replace(" ,", ",").Replace("&", " ").Replace("$", " ");
            Console.WriteLine(strText2);

        }
    }
}
