using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2019
{
    public abstract class Behandlung
    {
        private string kvNummer;
        private string beschreibung;
        private double kostensatz;

        protected Behandlung(string kvNummer, string beschreibung, double kostensatz)
        {
            this.kvNummer = kvNummer;
            this.beschreibung = beschreibung;
            this.kostensatz = kostensatz;
        }

        protected Behandlung()
        {
            this.kvNummer = "";
            this.beschreibung = "";
            this.kostensatz = 0;
        }

        public string KvNummer { get => kvNummer; set => kvNummer = value; }
        public string Beschreibung { get => beschreibung; set => beschreibung = value; }
        public double Kostensatz { get => kostensatz; set => kostensatz = value; }

        public abstract double get_Kosten();
    }
}
