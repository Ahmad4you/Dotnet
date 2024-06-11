using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2016
{
    /*
     * 
     * 
     * 2.3.3
       Die referentielle Integrität besagt: 
       - Attributwerte eines Fremdschlüssels als auch Attributwert des Primärschlüssels müssen vorhanden sein 
       - wenn über einen Fremdschlüssel auf einen Datensatz referenziert wird,
         muss der Zieldatensatz auch existieren. 
    
    Beispiel: Ausleihe hat bibNr 23, dann muss ein Medium mit der bibNr 23 auch vorhanden sein.
    
     * 
     * 
     */
    class Bibliothek
    {
        private List<Leser> leserliste = new List<Leser>();
        private List<Medium> medienliste = new List<Medium>();
        List<Medium> Vorgemerktlist;


        public int ermittleVormerkungen(int bibNr)  // wie oft ist ein cd ausgelihen?
        {
            int anzahl = 0;
           
            foreach (Leser item in leserliste)
            {
                    Vorgemerktlist = item.getVormerkliste;  // contains just ausgelihen Medien
                foreach (Medium i in Vorgemerktlist)
                    {
                        if (i.getBibNr == bibNr) anzahl++;
                    }
            }
            return anzahl;
        }

        //public int ermittleVormerkungen(int bibNr)  // wie oft ist ein cd ausgelihen?
        //{
        //    int anzahl = 0;

        //    foreach (Leser item in leserliste)
        //    {
        //        if (item.hatAusgeliehen(bibNr))
        //        {
        //            anzahl++;
        //        }
        //    }
        //    return anzahl;
        //}
    }
}
