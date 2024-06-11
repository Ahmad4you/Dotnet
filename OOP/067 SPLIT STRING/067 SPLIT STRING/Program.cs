using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067_SPLIT_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            string strText = "Welcom to Germany";

            //string[] strAll = strText.Split();
            //string[] strAll = strText.Split(' ');
            //string[] strAll = strText.Split(';');
            string[] strAll = strText.Split('e');

            foreach (string s in strAll)
            {
                Console.WriteLine(s);
            }
        }
    }
}
