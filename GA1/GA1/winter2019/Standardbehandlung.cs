using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2019
{
    class Standardbehandlung : Behandlung
    {
        public Standardbehandlung()
        {
            
        }

        public Standardbehandlung(string kvNummer, string beschreibung, double kostensatz) : base(kvNummer, beschreibung, kostensatz)
        {
        }


        public override double get_Kosten()
        {
            return base.Kostensatz;
        }
    }
}
