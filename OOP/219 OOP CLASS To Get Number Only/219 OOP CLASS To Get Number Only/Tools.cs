using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _219_OOP_CLASS_To_Get_Number_Only
{
    class Tools
    {
        public static int GetNumberOnly(string text)
        {
            string newText = "";
            foreach (char c in text.ToCharArray())
            {
                if ((c == '0') || (c == '1') || (c == '2') || (c == '3') || (c == '4') || (c == '5') || (c == '6') || (c == '7') || (c == '8') || (c == '9'))
                {
                    newText += c;
                }
            }
            if (newText == "") newText = "0";
            int newInt = Convert.ToInt32(newText);
            return newInt;
        }
        public static void PrintNumberOnly(string text)
        {
            Console.WriteLine(GetNumberOnly(text));
        }
    }
}
