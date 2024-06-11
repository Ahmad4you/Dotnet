using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GA1
{
    public abstract class Kunde
    {
        private int kundeNr;
        private string name;
        private string wohnort;
        private string straße;
        private string vorname;
        private int plz;
        private string telfonNr;
        private string email;

        public int KundeNr { get => kundeNr;  }
        public string Name { get => name;  }
        public string Wohnort { get => wohnort;  }
        public string Straße { get => straße; }
        public string Vorname { get => vorname;  }
        public int Plz { get => plz; }
        public string TelfonNr { get => telfonNr; }
        public string Email { get => email; }
    }
}