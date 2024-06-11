using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2020
{
    public abstract class Kunde
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected List<Karte> kartenliste;

        public List<Karte> Kartenliste
        {
            get { return kartenliste; }
            set { kartenliste = value; }
        }

        protected Kunde(string name)
        {
            this.name = name;
            kartenliste = new List<Karte>();
        }
        public virtual double berechneKartenPreis()   // virtual
        {
            double preis = 0;
            foreach (Karte item in kartenliste)
            {
                preis +=item.BerechneKartenPreis();  //from clss Karte
            }
            return preis;
        }
        public void kaufeKarte(double grundpreis, DateTime kaufTag, DateTime spielTag)
        {
            kartenliste.Add(new Karte(grundpreis, kaufTag, spielTag));
        }
    }
}
