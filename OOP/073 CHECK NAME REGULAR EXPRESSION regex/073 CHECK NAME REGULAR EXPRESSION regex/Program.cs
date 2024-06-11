using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _073_CHECK_NAME_REGULAR_EXPRESSION_regex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex reg = new Regex("^\\w$");   //one index -> true
            //Regex reg = new Regex("^\\w+$");    //one or more index -> true
            //Regex reg = new Regex("^[a-z]+$");    // one or more index -> just small letter
            //String text = "aa";
            //Console.WriteLine(reg.IsMatch(text));

            /*Regex reg = new Regex("^[A-Z][a-z]+$");*/  // A + hmad
            //Regex reg = new Regex("^[A-Z][a-z]+\\s[A-Z][a-z]+$");
            //Regex reg = new Regex("^[A-Z][a-z]+(\\s[A-Z][a-z]+)*$"); //Ahmad Dinan Leen
            //Regex reg = new Regex("^[ا-ي]+$");
            Regex reg = new Regex("^[ا-ي]+$|^([a-zA-Z]+(\\s[a-zA-Z]+)*)$"); // | = or

            Console.Write("Enter Your Name: ");
            String text = Console.ReadLine();
            Console.WriteLine(reg.IsMatch(text));
        }
    }
}
