using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2017
{
    public class Buchung
    {
        private string ausleiheDatum = "";

        public string get_AusleiheDatum()
        {
            return ausleiheDatum;
        }
        private string uhrzeit = "";

        public string get_Uhrzeit()
        {
            return uhrzeit; 
        }
        private string fahrer = "";

        public string get_Fahrer()
        {
            return fahrer; 
        }

        public Buchung(string ausleiheDatum, string uhrzeit, string fahrer)
        {
            this.ausleiheDatum = ausleiheDatum;
            this.uhrzeit = uhrzeit;
            this.fahrer = fahrer;
        }


    }
}
