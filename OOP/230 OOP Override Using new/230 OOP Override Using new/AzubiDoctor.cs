using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230_OOP_Override_Using_new
{
    class AzubiDoctor : Doctor
    {
        public override void PrintTyp()   // overridind with key word "override" u musst Person.PrintTyp() as virtual or abstract markieren
        {
            Console.WriteLine("Doctor");   // or override (override is continuas)
        }
    }
}
