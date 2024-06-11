using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_KreisVererbung
{
    abstract class KreisKörper
    {
        double radius;
        double höhe;

        public double Radius { get => radius; set => radius = value; }
        public double Höhe { get => höhe; set => höhe = value; }

        public KreisKörper(double radius, double höhe)
        {
            Radius = radius;
            Höhe = höhe;
        }
        public KreisKörper()
        {
         
        }

        public double getFläche()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double getUmfang()
        {
            return 2 * Math.PI * Radius;
        }
        public double GetMasse(double rho)
        {
            return Math.Round(rho * GetVolumen(), 2);
        }
        public double GetKosten(double kw, double rho)
        {
            return Math.Round(GetMasse(rho) * kw); //
        }

        public abstract double GetVolumen();
        public abstract double GetOberfläche();

        public override string ToString()
        {
            return "ich bin ein " + this.GetType() + " mit folgenden geometrischen Eigenschaften: \nVolumen: ";
        }
    }
}
