using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2019
{
    public class Patient
    {
        private string kvNummer;
        private string name;
        private string vorname;

        public Patient()
        {
            this.kvNummer = "";
            this.name = "";
            this.vorname = "";
        }

        public Patient(string kvNummer, string name, string vorname)
        {
            this.kvNummer = kvNummer;
            this.name = name;
            this.vorname = vorname;
        }

        public string get_KvNummer() { return kvNummer; }
        public string get_Name() { return name; }
        public string get_Vorname() { return vorname; }
    }
}
