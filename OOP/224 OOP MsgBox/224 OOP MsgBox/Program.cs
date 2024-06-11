using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _224_OOP_MsgBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tools.MsgBox("Hallo");
            if (Tools.MsgBoxYesNo("Do You Want to continue?", "Help me"))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }
}
