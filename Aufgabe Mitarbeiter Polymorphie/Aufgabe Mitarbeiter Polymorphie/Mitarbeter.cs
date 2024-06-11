using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Mitarbeiter_Polymorphie
{
    abstract class Mitarbeter
    {
        private string _Name;
        private string _Vorname;
        private int _Alter;
        private string _Gehalt;
        private string _ArbeitsZeit;
        private int _Urlaubstage;

        public string Name { get => _Name; set => _Name = value; }
        public string Vorname { get => _Vorname; set => _Vorname = value; }
        public int Alter { get => _Alter; set => _Alter = value; }
        public string Gehalt { get => _Gehalt; set => _Gehalt = value; }
        public string ArbeitsZeit { get => _ArbeitsZeit; set => _ArbeitsZeit = value; }
        public int Urlaubstage { get => _Urlaubstage; set => _Urlaubstage = value; }

        public virtual int GetUrlaubstage(int alter, int Überstunden = 0)
        {
            int AllgemeinUrlaubsanspruch =26;
            if(alter < 18)
            {
                AllgemeinUrlaubsanspruch += 5;
            }else if (alter >= 30 || alter <=40)
            {
                AllgemeinUrlaubsanspruch += 2;
            }else if (alter >= 40 || alter <= 50)
            {
                AllgemeinUrlaubsanspruch += 4;
            }
            else if (alter > 50)
            {
                AllgemeinUrlaubsanspruch += 6;
            }

            return AllgemeinUrlaubsanspruch;
        }
        static void GetMitarbeiterUrlaubstage(Mitarbeter mitarbeter, int alter)
        {
            mitarbeter.GetUrlaubstage(alter);
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nVorname: " + Vorname + "\nMitarbeitertyp: " + this.GetType();
        }
    }
}
