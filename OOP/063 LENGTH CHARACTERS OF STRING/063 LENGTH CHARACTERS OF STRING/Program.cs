using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_LENGTH_CHARACTERS_OF_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name and the max digit is 10: ");
            string strName = Console.ReadLine();
            if( strName.Length > 10)
            {
                Console.WriteLine("Invalid Name");
            }
            else
            {
                Console.WriteLine("Hallo " + strName);
            }
        }
    }
}
