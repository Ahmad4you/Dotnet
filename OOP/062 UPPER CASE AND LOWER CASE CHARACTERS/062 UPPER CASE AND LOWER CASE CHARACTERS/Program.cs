using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _062_UPPER_CASE_AND_LOWER_CASE_CHARACTERS
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "sghkus";
            //string str2 = str.ToUpper();
            //Console.WriteLine(str2);

            //string str = "ABCDEFG";
            //Console.WriteLine(str.ToLower());

            String strName = "ahmad";
            string strName2 = "";

            char[] cName = strName.ToCharArray();
            for( int x = 0; x < 5; x++)
            {
                if(x == 2 || x == 3)
                {
                    strName2 += cName[x].ToString().ToUpper();
                }
                else
                {
                    strName2 += cName[x];
                }
            }
                Console.WriteLine(strName2);
        }
    }
}
