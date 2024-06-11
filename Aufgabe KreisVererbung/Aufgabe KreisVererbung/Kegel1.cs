using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_KreisVererbung
{
    class Kegel1 : KreisKörper
    {
        public Kegel1(double radius, double höhe) : base(radius, höhe)
        {

        }

        public override double GetVolumen()
        {
            return getFläche() * Höhe / 3;
        }

        public override double GetOberfläche()
        {
            return getFläche() + Math.PI * Radius * Math.Sqrt(Radius * Radius + Höhe * Höhe);
        }
    }
}
