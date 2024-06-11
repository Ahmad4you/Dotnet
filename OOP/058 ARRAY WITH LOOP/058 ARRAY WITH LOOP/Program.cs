using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _058_ARRAY_WITH_LOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strNames = new string[5];
            //strNames[0] = "Ahmad";
            //strNames[1] = "Diana";
            //strNames[2] = "Leen";
            //strNames[3] = "Reham";
            //strNames[4] = "Ragad";

            //for (int x = 0; x <= strNames.Length-1 ; x++)
            //for (int x = 0; x < strNames.Length; x++)
            //{
            //    Console.WriteLine(strNames[x]);
            //}

            Console.Write("Enter the number of Employees: ");
            int empCount = int.Parse(Console.ReadLine());
            string[] strEmps = new string[empCount];

            for(int x = 0; x < empCount; x++)
            {
                Console.Write("Enter Employee " +  (x+1)   +" :  ");
                strEmps[x] = Console.ReadLine();
            }

            for (int x = 0; x < empCount; x++)
            {
                Console.WriteLine("   " + strEmps[x]);
            }

        }
    }
}
