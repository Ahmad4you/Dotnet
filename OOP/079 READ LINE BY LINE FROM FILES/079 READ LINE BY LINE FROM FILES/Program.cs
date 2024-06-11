using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _079_READ_LINE_BY_LINE_FROM_FILES
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sw = new StreamWriter("myFile.txt", false, Encoding.Unicode);
            StreamReader sr = new StreamReader("myFile1.txt");
            string strAllLines = sr.ReadToEnd();
            Console.WriteLine(strAllLines);

            //string line;
            //do
            //{
            //    line = sr.ReadLine();
            //    Console.WriteLine(line);
            //} while (line != null);
        }
    }
}
