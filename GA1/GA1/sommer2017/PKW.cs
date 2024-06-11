using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2017
{
    /*** Bei der Beziehung handelt es sich um eine --composition--.
    * Ein Pkw-Objekt ist mit keinem, einem oder mehreren Buchungsobjekten verbunden{*}.
    * Ein Buchungsobjekt ist genau einem Pkw-Objekt zugeordnet.
    * Beim Erzeugen ein Pkw-Objekt wird Die Buchungsliste erzeugt 
    * Beim Aufruf der Methode mieten() werden Buchung-Objekte in der Liste hinzugefügt.
    * Wird das Pkw-Objekt zerstört, werden auch die Buchungen für dieses Fahrzeug gelöscht. 
    */
    class PKW
    {
        private int kategorie = 0;

        public int Kategorie
        {
            get { return kategorie; }
            set { kategorie = value; }
        }
        private string modell = "";

        public string Modell
        {
            get { return modell; }
            set { modell = value; }
        }
        private string farbe = "";

        public string Farbe
        {
            get { return farbe; }
            set { farbe = value; }
        }
        private int erstzulassungsJahr = 0;

        public int ErstzulassungsJahr
        {
            get { return erstzulassungsJahr; }
            set { erstzulassungsJahr = value; }
        }
        private int kmStand = 0;

        public int Kmstand
        {
            get { return kmStand; }
            set { kmStand = value; }
        }
        private List<Buchung> ausleihDatenList;  

        public List<Buchung> AusleihDatenList
        {
            get { return ausleihDatenList; }
            set { ausleihDatenList = value; }
        }

        public PKW()
        {
            ausleihDatenList = new List<Buchung>();  // composition
        }

        public PKW(int kategorie, string modell, string farbe, int erstzulassungsJahr, int kmStand)
        {
            ausleihDatenList = new List<Buchung>();  // composition
            this.kategorie = kategorie;
            this.modell = modell;
            this.farbe = farbe;
            this.erstzulassungsJahr = erstzulassungsJahr;
            this.kmStand = kmStand;
        }

        public bool mieten(string ausleiheDatum, string uhrzeit, string fahrer, int kmStand)
        {
            this.kmStand = kmStand;
            Buchung buchung = new Buchung(ausleiheDatum, uhrzeit, fahrer);

            foreach (Buchung item in ausleihDatenList)
            {
                if (item.get_AusleiheDatum() == buchung.get_AusleiheDatum()  // ausleiheDatum
                    && item.get_Uhrzeit() == buchung.get_Uhrzeit())   // uhrzeit
                {
                    return false;
                }
            }
            ausleihDatenList.Add(buchung );
            return true;
        }
    }
}
