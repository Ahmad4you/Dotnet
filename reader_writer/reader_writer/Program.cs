using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reader_writer
{
    class Program
    {
        static void Main(string[] args)
        {

            //string manyLines = @"This is line one 
            //    This is line two
            //    Here is line three  
            //    The penultimate line is line four
            //    This is the final, fifth line.";

            // var reader = new StringReader(manyLines);

            //string item;
            //do
            //{
            //    item = reader.ReadLine();
            //    Console.WriteLine(item);
            //} while (item != null);


            //        string numbers = @"
            //        One
            //        Two
            //        Three
            //        Four.";
            //        string letters = @"
            //        A
            //        B
            //        C
            //        D.";

            //        using (StringReader left = new StringReader(numbers),
            //          right = new StringReader(letters))
            //        {
            //            string item;
            //            do
            //            {
            //                item = left.ReadLine();
            //                Console.Write(item);
            //                Console.Write("    ");
            //                item = right.ReadLine();
            //                Console.WriteLine(item);
            //            } while (item != null);
            //        }

            classreader c1 = new classreader();
            var fileToread = @"C:\Users\tss3\Desktop\test.csv";

            var fileTOwrite = @"C:\Users\tss3\Desktop\myOutput.csv";

            c1.ReadWriteCsv(fileToread, fileTOwrite);

        }
            
    }
}
