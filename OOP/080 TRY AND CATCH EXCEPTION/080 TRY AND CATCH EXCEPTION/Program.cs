using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080_TRY_AND_CATCH_EXCEPTION
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int a = 55, b = 0, r;
                //r = a / b;
                //Console.WriteLine(r);

                string[] strName = new string[2];
                strName[3] = "blabla";
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally!!!");
            }

            try
            {
                int a = 55, b = 0, r;
                r = a / b;
                Console.WriteLine(r);

                string[] strName = new string[2];
                strName[3] = "blabla";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally!!!");
            }
        }
    }
}
