using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_ARRAY_LENGTH_AND_CHAR_ARRAY_WITH_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the count: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //string[] str = new string[c];
            //str[0] = "Ahmad";
            //str[str.Length - 1] = "Diana";

            //int arrayCount = str.Length;
            //Console.WriteLine("arrayCount: " + arrayCount);
            //Console.WriteLine(str[str.Length-1]);

            //char[] cName = new char[5];
            //cName[0] = 'A';
            //cName[1] = 'h';
            //cName[2] = 'm';
            //cName[3] = 'a';
            //cName[4] = 'd';
            ////Console.WriteLine(cName);
            ////Console.WriteLine(cName[0].ToString() + cName[1] + cName[2]);
            //string strName = new string(cName);
            //Console.WriteLine(strName);

            string strName = "Ahmad";
            char[] cName;
            cName = strName.ToCharArray();
            Console.WriteLine(cName);


        }
    }
}
