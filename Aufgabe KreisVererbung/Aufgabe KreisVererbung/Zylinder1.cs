using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_KreisVererbung
{
    class Zylinder1 : KreisKörper
    {
        public Zylinder1(double radius, double hoehe): base(radius, hoehe)
        {

        }

        public override double GetVolumen()
        {
            return getFläche() * Höhe;
        }

        public override double GetOberfläche()
        {
            return 2 * getFläche() + getUmfang() * Höhe;
        }
    }
}
