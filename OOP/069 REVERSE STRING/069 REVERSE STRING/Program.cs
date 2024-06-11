using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_REVERSE_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = "   welcom to Germany         ";
            string strReverse = "";

                for(int x = str.Length -1; x >= 0; x--)
            {
                strReverse += str[x];
            }
            Console.WriteLine(strReverse);

            string str2 = str.Trim();
            Console.WriteLine(str2);
        }
    }
}
