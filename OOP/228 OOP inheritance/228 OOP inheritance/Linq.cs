using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _228_OOP_inheritance
{
    class Linq
    {
        public static void getLinq_geradezahl()           // Ling Abfrage Methode
        {
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int geradezahl in numQuery)
            {
                Console.Write("{0,1} ", geradezahl);
            }
        }

        public static void getLinq_ungeradezahl()           // Ling Abfrage Methode
        {
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 1
                select num;

            // 3. Query execution.
            foreach (int ungeradezahl in numQuery)
            {
                Console.WriteLine("{0,1} ", ungeradezahl);
            }
        }

    }
}
