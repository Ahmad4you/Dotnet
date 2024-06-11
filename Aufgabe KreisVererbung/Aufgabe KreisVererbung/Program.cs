using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_KreisVererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * V = 501.87 / O = 427.53
             * 
             * Lösungsvochläge des weitern Aufgabes
             */
            Zylinder1 z = new Zylinder1(2, 2);
            Kegel1 k = new Kegel1(2, 2);

            Console.WriteLine("Zylinder Volumen: " + z.GetVolumen());
            Console.WriteLine("Zylinder Fläche: " + z.GetOberfläche());
            Console.WriteLine("Kegel Volumen: " + k.GetVolumen());
            Console.WriteLine("Kegel Volumen: " + k.GetOberfläche());
        }
    }
}
