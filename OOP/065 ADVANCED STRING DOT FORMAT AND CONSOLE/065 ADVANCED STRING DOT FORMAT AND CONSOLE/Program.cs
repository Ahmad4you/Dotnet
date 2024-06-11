using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _065_ADVANCED_STRING_DOT_FORMAT_AND_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            //int invoiceNum = 12;
            //Console.WriteLine(string.Format("{0}", invoiceNum));
            //Console.WriteLine(string.Format("{0:00000}", invoiceNum));

            //int[] invoiceNum = { 445, 7875, 234, 32, 457, 3456, 234, 6 };
            //foreach(int i in invoiceNum)
            //{
            //    Console.WriteLine(string.Format("{0:00000}", i));
            //}

            //int price = 150;
            //Console.WriteLine(string.Format("{0:c}", price));
            //Console.WriteLine(string.Format("{0:c0}", price));
            //Console.WriteLine(string.Format("{0:c6}", price));

            //int salary = 7000;
            ////string strSal = string.Format("{0:f}", salary);
            ////string strSal = string.Format("{0:f0}", salary);
            //string strSal = string.Format("{0:f3}", salary);
            //Console.WriteLine(strSal);

            //DateTime dt = Convert.ToDateTime("01/01/2000 00:00:01");
            ////string myDate = string.Format("{0}", dt);
            //string myDate = string.Format("{0:MMMM}", dt);
            //Console.WriteLine(myDate);

            //int num = 1055;
            //Console.WriteLine(string.Format("{0:x}", num)); //Hexadezimal

            string strName = "Ahmad";
            Console.WriteLine("Name : {0}", strName);
        }
    }
}
