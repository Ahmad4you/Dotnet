using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _061_GENERATE_RANDOM_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int r = rnd.Next();
            //Console.WriteLine(r);

            //Random rnd = new Random();
            //int rNum = rnd.Next(1, 20);   // Max < 20
            //Console.WriteLine(rNum);

            //Random rnd = new Random();
            //int rNum = rnd.Next(1, 13);   // Max < 12
            //int rNum2 = rnd.Next(1, 13);   // Max < 12
            //DateTime dt = Convert.ToDateTime(rNum + "/" + rNum2 + "/2000");
            //Console.WriteLine(dt);

            Random rnd = new Random();
            int rNum = rnd.Next(1, 13);   // Max < 12
            DateTime dt = Convert.ToDateTime(rNum + "/" + rNum + "/2000");
            Console.WriteLine(dt.ToString("MMMM"));

        }
    }
}
