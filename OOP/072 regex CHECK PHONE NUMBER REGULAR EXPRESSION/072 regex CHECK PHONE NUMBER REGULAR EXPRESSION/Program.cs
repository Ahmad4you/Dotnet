using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _072_regex_CHECK_PHONE_NUMBER_REGULAR_EXPRESSION
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * using System.Text.RegularExpressions;
             * 
             * [a–z]	In the a-z range
             * [^a–z]	Not in the a-z range
             * .	Any except \n (new line)
             * \char	Escaped special character
             * \t	Horizontal tab	\u0009
             * \v	Vertical tab	\u000B
             * \b	Backspace	\u0008
             * \e	Escape	\u001B
             * \r	Carriage return	\u000D
             * \f	Form feed	\u000C
             * \n	New line	\u000A
             * \a	Bell (alarm)	\u0007
             * \w	Word character
             * \W	Non-word character
             * \d	Decimal digit
             * \D	Not a decimal digit
             * \s	White-space character
             * \S	Non-white-space char
             * *		0 or more times
             * +		1 or more times
             * ?		0 or 1 time
             * {n}		Exactly n times
             * {n,}		At least n times
             * {n,m}	From n to m times
             * ^	At start of string or line
             * $	At end (or before \n at end) of string or line
             * \A	At start of string
             * \z	At end of string
             * (exp)	Indexed group
             * (?<name>exp)	Named group
             * 
             * 
             */

            //Console.WriteLine("\\");

            //Regex reg = new Regex("^\\d$");   // start+(Dezimalzahl)+end
            //Regex reg = new Regex("^\\d{3}$");   // start+3(Dezimalzahl)+end
            //Regex reg = new Regex("^\\d+$");     // 1 or more times
            //Regex reg = new Regex("^\\d*$");
            //Regex reg = new Regex("^\\d?$");
            //Regex reg = new Regex("^\\d{3,8}$");
            //Regex reg = new Regex("^\\d{3}-\\d{8}$");  //002-12345678
            Regex reg = new Regex("^\\d{3}-\\d{8,10}$");

            Console.Write("Enter Number: ");
            string text = Console.ReadLine();

            if (reg.IsMatch(text))
            {
                Console.WriteLine("Correct Number");
            }
            else
            {
                Console.WriteLine("Invalid Number!!!");
            }

        }
    }
}
