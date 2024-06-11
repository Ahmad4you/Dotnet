using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_KreisVererbung
{
    class ZylinderKegel : Zylinder1
    {
        public Kegel1 kegel;

        //public ZylinderKegel()
        //{
        //}
        public ZylinderKegel(double radiusZyl, double hoeheZyl, double radiusKeg, double hoeheKeg): base(radiusZyl, hoeheZyl)
        {
            kegel = new Kegel1(radiusKeg, hoeheKeg);
        }
        public override double GetVolumen()
        {
            return base.GetVolumen() - kegel.GetVolumen();
        }
        public override double GetOberfläche()
        {
            return (base.GetOberfläche() + kegel.GetOberfläche() - 2* kegel.getFläche());
        }
        // wieso 2 mal von kegel.getFläche() abziehen
        // es muss 2 mal beruksichtigen 1mal vom Kegel und 1mal vom Zylinder, Kreisfläche von Kegel muss 2mal gerechnet werden
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
