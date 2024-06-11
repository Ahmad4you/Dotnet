using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_FOREACH_LOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strName = { "Ahmad", "Diana", "Leen" };
            //for(int x = 0; x < strName.Length; x++)
            //{
            //    Console.WriteLine(strName[x]);
            //}

            foreach(string item in strName)
            {
                Console.WriteLine(item);
            }

            string strVorname = "Ahmad";
            char[] cVorname = strVorname.ToCharArray();

            foreach(char c in cVorname)
            {
                Console.WriteLine(c);
            }

            foreach (char c in strVorname)
            {
                Console.WriteLine(c);
            }
        }
    }
}
