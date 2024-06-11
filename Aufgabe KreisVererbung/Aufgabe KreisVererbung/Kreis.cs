using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_KreisVererbung
{
    class Kreis
    {
        private double radius;

        public double Radius { get { return radius; } set { radius = value; } }

        public Kreis(double radius)
        {
            Radius = radius;
        }


        public double getFläche()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double getUmfang()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
