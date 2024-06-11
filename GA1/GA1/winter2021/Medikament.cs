using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2021
{
    class Medikament
    {
        private string haltbarkeitsdatum;

        public string Haltbarkeitsdatum
        {
            get { return haltbarkeitsdatum; }
            set { haltbarkeitsdatum = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string wirksamkeit;

        public string Wirksamkeit
        {
            get { return wirksamkeit; }
            set { wirksamkeit = value; }
        }
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private Medikamentenform medikamentenform;  // composition Verweiss

        public Medikamentenform Medikamentenform
        {
            get { return medikamentenform; }
            set { medikamentenform = value; }
        }

        public Medikament(string haltbarkeitsdatum, string name, string wirksamkeit, long id, Medikamentenform medikamentenform)
        {
            this.haltbarkeitsdatum = haltbarkeitsdatum;
            this.name = name;
            this.wirksamkeit = wirksamkeit;
            this.medikamentenform = medikamentenform;
            this.id = id;
        }


    }
}
