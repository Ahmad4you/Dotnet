using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2020
{
    public class Karte
    {
        private double grundpreis;

        public double Grundpreis
        {
            get { return grundpreis; }
            set { grundpreis = value; }
        }
        private DateTime spielTag;

        public DateTime SpielTag
        {
            get { return spielTag; }
            set { spielTag = value; }
        }
        private DateTime gekauftAm;

        public DateTime GekauftAm
        {
            get { return gekauftAm; }
            set { gekauftAm = value; }
        }

        public Karte(double grundpreis, DateTime spielTag, DateTime kaufTag)
        {
            this.grundpreis = grundpreis;
            this.spielTag = spielTag;
            this.gekauftAm = kaufTag;
        }
        public double BerechneKartenPreis()
        {
            int diffTage = (spielTag - gekauftAm).Days;
            if(diffTage > 30)
            {
                return grundpreis * 0.90;
            }
            else
            {
                return grundpreis;
            }
        }
    }
}
