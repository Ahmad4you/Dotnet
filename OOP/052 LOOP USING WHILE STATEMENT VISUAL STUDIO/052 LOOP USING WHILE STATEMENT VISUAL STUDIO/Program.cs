using System;

namespace _052_LOOP_USING_WHILE_STATEMENT_VISUAL_STUDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("Hello World!");
            //}

            //int x = 1;
            //while (x <= 7)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            int x = 1;
            while (true)
            {
                Console.WriteLine(x);
                x++;
                if (x > 10) break;
            }

        }
    }
}
