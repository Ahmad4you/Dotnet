using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_KreisVererbung
{
    class Zylinder : Kreis
    {
        double höhe;

        public double Höhe { get { return höhe; } set { höhe = value; } }

        public Zylinder(double radius, double heohe) : base(radius)
        {
            Höhe = heohe;
        }

        public double GetVolumen()
        {
            return getFläche() * Höhe;
        }

        public double GetOberfläche()
        {
            return 2 * getFläche() + getUmfang() * Höhe;
        }
    }
}
