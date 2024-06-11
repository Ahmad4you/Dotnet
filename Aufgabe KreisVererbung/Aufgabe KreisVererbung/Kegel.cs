using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_KreisVererbung
{
    class Kegel : Kreis
    {
        double höhe;

        public double Höhe { get { return höhe; } set { höhe = value; } }

        public Kegel(double radius, double höhe): base(radius)
        {
            Höhe = höhe;
        }

        public double GetVolumen()
        {
            return getFläche() * Höhe / 3;
        }

        public double GetOberfläche()
        {
            return getFläche() + Math.PI * Radius * Math.Sqrt(Radius * Radius + Höhe * Höhe);
        }
    }
}
