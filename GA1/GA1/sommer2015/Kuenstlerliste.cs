using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommer2015
{
    class Kuenstlerliste
    {
        // Aggregation relationshipp (optional) must init outer constructor
        //public Kuenstlergruppe kungruppe;  // 1 to 1
        private List<Kuenstlergruppe> gruppen = new List<Kuenstlergruppe>();  // 1 to *
        

        public void Hinzufuegen(Kuenstlergruppe kuenstlergruppe)
        {
            gruppen.Add(kuenstlergruppe);
        }

        public bool Entfernen(Kuenstlergruppe kuenstlergruppe)
        {
            if (gruppen.Remove(kuenstlergruppe) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            if (gruppen == null)
            {
                return null;
            }
            return gruppen.ToString();
        }

        public Kuenstlergruppe getIndex(int i)
        {
            if (gruppen[i] == null || i <= 0)
            {
                return null;
            }
            return gruppen[i];

        }

        
    }
}
