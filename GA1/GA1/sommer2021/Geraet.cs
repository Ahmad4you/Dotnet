using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2021
{
    class Geraet
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private protected bool defekt;

        //public bool Defekt
        //{
        //    get { return defekt ; }
        //    set { defekt = value; }
        //}

        private protected Nachrichtenschlange schlange;

        //public Nachrichtenschlange Schlange
        //{
        //    get { return schlange; }
        //    set { schlange = value; }
        //}

        public Geraet(string id, Nachrichtenschlange schlange)
        {
            this.id = id;
            this.defekt = false;
            this.schlange = schlange;
        }

        public string hole_Id()
        {
            return this.id;
        }
    }
}
