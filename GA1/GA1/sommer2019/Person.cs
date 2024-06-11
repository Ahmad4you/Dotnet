using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2019
{
    public class Person
    {
        private string nachname;
        private string vorname;

        public Person()
        {
            this.nachname = "";
            this.vorname = "";
        }

        public Person(string nachname, string vorname)
        {
            this.nachname = nachname;
            this.vorname = vorname;
        }

        public string get_Nachname()
        {
            return this.nachname;
        }
        public string get_Vorname()
        {
            return this.vorname;
        }
    }
}
