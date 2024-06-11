using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _212_OOP_Print_String_Array_Class
{
    class PrintStringArray
    {
        string[] content;

        public PrintStringArray(string[] content)
        {
            this.content = content;
        }
        public string GetStrArray(string separator)
        {
            string stringArray = "";

            foreach (string s in content)
            {
                stringArray += s + separator;
            }
            return stringArray;
        }
        public void PrintStrArray(string separator)
        {
            Console.WriteLine(GetStrArray(separator));
        }
    }
}
