using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_DO_WHILE_LOOP_STATEMENT_VISUAL_STUDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int x = 1; true; x++)
            //{
            //    Console.WriteLine(x);
            //}

            //do
            //{
            //    Console.WriteLine("11");

            //} while (true);

            //int x = 1;
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;
            //} while (x <= 10);

            //int x = 1331;
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;
            //} while (false);

            string strYN = "";
            do
            {
                int num1;
                int num2;
                int result;
                Console.Write("Enter Number1: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Number2: ");
                num2 = int.Parse(Console.ReadLine());
                result = num1 + num2;
                Console.WriteLine("-----------------");
                Console.WriteLine(result);
                Console.WriteLine("-----------------");
                Console.WriteLine("Do You Want Tray Again!! Y/N");
                strYN = Console.ReadLine();
            } while (strYN == "y" || strYN == "Y");
        }
    }
}
