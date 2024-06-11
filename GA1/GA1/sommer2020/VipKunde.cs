using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2020
{
    class VipKunde : Kunde
    {
        private string telefonnummer;

        public string Telefonnummer
        {
            get { return telefonnummer; }
            set { telefonnummer = value; }
        }
        private List<VipKunde> vipFreundeList = new List<VipKunde>();

        public List<VipKunde> VipFreundeList
        {
            get { return vipFreundeList; }
            set { vipFreundeList = value; }
        }


        public VipKunde(string telefonnummer, string name) : base(name)
        {
            this.telefonnummer = telefonnummer;
        }

        public VipKunde(string telefonnummer, string name, List<VipKunde> freunde) : base(name)
        {
            this.telefonnummer = telefonnummer;
            //freunde = new List<VipKunde>();
            this.vipFreundeList = freunde;
        }

        public override double berechneKartenPreis()
        {
            double kartpreis= base.berechneKartenPreis();
            if (vipFreundeList.Count > 1) kartpreis *= 0.95;  // 5% zusätzliche Rabatt
            return kartpreis;
        }
    }
}
