using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _074_CHECK_EMAIL_REGULAR_EXPRESSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Email: ");
            String strEmail = Console.ReadLine();
            Regex reg = new Regex(@"^\w+([.-_]\w+)*@\w+([.-]\w+)*\.\w+([.-]\w+)*$"); // @ = you can in C# just on backslasch to write

            if (reg.IsMatch(strEmail))
            {
                Console.WriteLine("Correct E-mail...");
            }
            else
            {
                Console.WriteLine("Invalid E-mail!!!");
            }
        }
    }
}
