using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2018
{
    class Industrieroboter
    {
        private static int maxAnzhalWerkzeuge = 10;

        public int MaxAnzhalWerkzeuge { get => maxAnzhalWerkzeuge; }

        private List<Werkzeug> werkzeugskasten;

        public Industrieroboter()
        {
            werkzeugskasten = new List<Werkzeug>(maxAnzhalWerkzeuge);
        }

        public bool werkzeugHinzufuegen(int platz, Werkzeug neueswerkzeug)
        {
            bool pruefung = false;
            if (platz >= 0 && platz <= 10)
            {
                Console.WriteLine("gib ein Zahl zwischen 1 und 10");
                pruefung = false;
            }
            for (int i = 0; i <= werkzeugskasten.Capacity - 1; i++)
            {

                if (i == platz && werkzeugskasten.Contains(neueswerkzeug))
                {
                    
                    Console.WriteLine("Werkzeug schon ist vorhanden");
                    pruefung = false;
                }
                else if (i == platz && !werkzeugskasten.Contains(neueswerkzeug))
                {
                    werkzeugskasten.Add(neueswerkzeug);
                    Console.WriteLine("neueswerkzeug wurde Hinzugefügt");
                    pruefung = true;
                }

            }
            return pruefung;
        }

        public bool werkzeugEntfernen(int platz)
        {    
               //Werkzeug[] werkzeugarray = werkzeugskasten.ToArray();
            if (platz >= 0 && platz <= 10)
            {
                Console.WriteLine("gib ein Zahl zwischen 1 und 10");
                return false;
            }
            for (int i = 0; i <= werkzeugskasten.Capacity - 1; i++)
            {

                if (i == platz && werkzeugskasten[i] != null)
                {
                    werkzeugskasten.RemoveAt(platz);
                    Console.WriteLine("Werkzeug wurde erfolgrisch gelöscht");
                    return true;
                }
            }
            Console.WriteLine("Werkzeug wurde nicht gelöscht");
            return false;
        }
    }
}
