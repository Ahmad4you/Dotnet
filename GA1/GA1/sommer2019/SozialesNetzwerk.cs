using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2019
{
    class SozialesNetzwerk
    {
        private List<Person> mitglierderListe;
        private List<Nachricht> nachrichtenListe;

        public List<Person> MitglierderListe { get => mitglierderListe; set => mitglierderListe = value; }
        public List<Nachricht> NachrichtenListe { get => nachrichtenListe; set => nachrichtenListe = value; }

        public SozialesNetzwerk()
        {
            mitglierderListe = new List<Person>();
            nachrichtenListe = new List<Nachricht>();
        }

        public void hinzufuegenMitglied(Person person)
        {
            if (person != null) mitglierderListe.Add(person);
        }

        public void hinzufuegenNachricht(Nachricht nachricht)
        {
            if (nachricht != null) nachrichtenListe.Add(nachricht);
        }

        public string getAlleNachrichten()
        {
            string output= "";
            foreach (Nachricht item in nachrichtenListe)
            {
                output += item.getNachricht() + " \n ";
            }
            return output;
        }
    }
}
