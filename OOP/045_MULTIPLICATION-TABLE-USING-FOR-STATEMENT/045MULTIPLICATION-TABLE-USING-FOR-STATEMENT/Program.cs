using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_MULTIPLICATION_TABLE_USING_FOR_STATEMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //for(; ; )
            //{
            //    Console.WriteLine(x);
            //    x++;
            //    if(x > 1000)
            //    {
            //        break;
            //    }
            //}

            int BaseName;
            Console.Write("Enter The Number: ");
            BaseName = int.Parse(Console.ReadLine());

            for(int num=1; num <=10; num++)
            {
                Console.WriteLine(BaseName + " * " + num + " =   " + BaseName*num);
            }
        }
    }
}
