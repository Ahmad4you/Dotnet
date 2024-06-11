using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2021
{
    public abstract class Medikamentenform
    {
        private double gewichtInG;

        public double GewichtInG
        {
            get { return gewichtInG; }
            set { gewichtInG = value; }
        }
        private double laengeInMm;

        public double LaengeInMm
        {
            get { return laengeInMm; }
            set { laengeInMm = value; }
        }
        private double breiteInMm;

        public double BreiteInMm
        {
            get { return breiteInMm; }
            set { breiteInMm = value; }
        }
        private long id;

        //public long Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        public Medikamentenform(double gewichtInG, double laengeInMm, double breiteInMm, long id)
        {
            this.gewichtInG = gewichtInG;
            this.laengeInMm = laengeInMm;
            this.breiteInMm = breiteInMm;
            this.id = id;
        }

        public abstract string wirkstofffreisetzung();

        
    }
}
