using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_NESTED_FOR_STATEMENT_VISUAL_STUDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int x = 1; x <= 5; x++)
            //{
            //    Console.WriteLine(x);
            //    for(int y = 1; y <=3; y++)
            //    {
            //        Console.WriteLine("     " + x + " >>" + y);
            //    }
            //}

            //for(int dept = 1; dept <= 4; dept++)
            //{
            //    Console.WriteLine("Departement " + dept);
            //    Console.WriteLine("------------------------------");
            //    for(int emp = 1; emp <= 3; emp++)
            //    {
            //        Console.WriteLine("Employee " + emp);
            //    }
            //    Console.WriteLine("===============================");
            //}

            for(int baseName = 1; baseName <= 10; baseName++)
            {
                Console.WriteLine("Tabel : " + baseName);
                Console.WriteLine("------------------------------");
                for(int num = baseName; num <= 10; num++)
                {
                    Console.WriteLine(" " + baseName + "  *  " + num + " = " + baseName*num);
                }
                Console.WriteLine("===============================");
            }
        }
    }
}
