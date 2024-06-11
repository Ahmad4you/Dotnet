using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Mitarbeiter_Polymorphie
{
    class Personal : Mitarbeter
    {
        ArrayList neuMitarbeiter = new ArrayList();

        public Personal(string name, string vorname, int alter)
        {
            Name = name;
            Vorname = vorname;
            Alter = alter;
        }
        public void neuerMitarbeiter()
        {
            neuMitarbeiter.Add(Name);
            neuMitarbeiter.Add(Vorname);
            neuMitarbeiter.Add(Alter);
        }
    }
}
