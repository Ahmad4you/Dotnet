using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommer2015
{
    class Musikgruppe : Kuenstlergruppe
    {
        private static double aktGemaPauschale= 22.1;
        private double preisProStunde;
        private string musikStil;

        public Musikgruppe(string name, string musikStil, double preisProStunde) : base(name)
        {
            this.musikStil = musikStil;
            this.preisProStunde = preisProStunde;

        }
        public double getaktGemaPauschale()
        {
            return aktGemaPauschale;
        }
        public double getpreisProStunde()
        {
            return preisProStunde;
        }

        public override string GetArt()
        {
            return "Musikgruppe: " + musikStil;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
