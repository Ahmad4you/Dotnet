using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _064_STRING_DOT_FORMAT
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName = "Ahmad";
            string strJob = "programmer";
            string strPhone = "01625563776";

            string strData = "Name: " + strName + "\nJob: " + strJob + "\nphone: " + strPhone;
            Console.WriteLine(strData);
            string strDataFormat = string.Format("Name: {0}\nJob: {1}\nphone: {2}", strName, strJob, strPhone);
            Console.WriteLine(strDataFormat);
        }
    }
}
