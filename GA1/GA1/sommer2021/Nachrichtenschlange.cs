using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2021
{
     class Nachrichtenschlange
    {
        private List<Nachricht> nachrichtListe;

        public List<Nachricht> NachrichtListe
        {
            get { return nachrichtListe; }
            set { nachrichtListe = value; }
        }

        public Nachrichtenschlange()
        {
            this.nachrichtListe = new List<Nachricht>();
        }

        public void neueNachricht(Nachricht nachricht)
        {
            this.nachrichtListe.Add(nachricht);
        }
        public void drucke()
        {
            //int counter = 0;
            //foreach (Nachricht item in nachrichtListe)
            //{  
            //    Console.WriteLine($"{counter++}-Nachrichtnummer: {item.Id} \t\t\tNachricht:  {item.Text}");
            //}

            for (int i = 0; i < nachrichtListe.Count; i++)
            {
                Console.WriteLine($"{i}-Nachrichtnummer: {nachrichtListe[i].Id} \t\t\tNachricht: {nachrichtListe[i].Text}");
            }
        }
    }
}
