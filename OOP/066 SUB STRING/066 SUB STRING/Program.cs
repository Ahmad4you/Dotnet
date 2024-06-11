using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _066_SUB_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            string strText = "Hallo World!";
            //string strSubText = strText.Substring(1);
            //string strSubText = strText.Substring(3);
            //string strSubText = strText.Substring(0, 3);
            //string strSubText = strText.Substring(0, 5);

            //Console.WriteLine(strSubText);

            Console.Write("Enter the File Name: ");
            string strFileName = Console.ReadLine();
            string strFileName2 = "";
            if(strFileName.Length > 4)
            {
                strFileName2 = strFileName.Substring(0, strFileName.Length - 4);
            }

            Console.WriteLine(strFileName2);
        }
    }
}
