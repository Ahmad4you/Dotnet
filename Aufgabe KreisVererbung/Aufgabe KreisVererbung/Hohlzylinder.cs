using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_KreisVererbung
{
    class Hohlzylinder : Zylinder1
    {
        Zylinder1 zylinder_I;

        public Hohlzylinder(double ra, double ri, double h): base(ra, h)
        {
            zylinder_I = new Zylinder1(ri, h);
        }
        public override double GetVolumen()
        {
            return (base.GetVolumen() - zylinder_I.GetVolumen());
        }
        public override double GetOberfläche()
        {
            return (base.GetOberfläche() + zylinder_I.GetOberfläche() - 4* zylinder_I.getFläche());
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
