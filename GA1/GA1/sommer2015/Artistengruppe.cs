using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommer2015
{
    class Artistengruppe : Kuenstlergruppe
    {
        private double _pauschalPreis;
        private string gerne;

        List<Kuenstlergruppe> artist = new List<Kuenstlergruppe>();

        public Artistengruppe(string name, string gerne, double pauschalPreis) : base(name)
        {
            this.gerne = gerne;
            this._pauschalPreis = pauschalPreis;
        }

        public double get_pauschalPreis()
        {
            return _pauschalPreis;
        }

        public override string GetArt()
        {
            return gerne;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //public Artistengruppe(string name) : base(name)
        //{
        //}  alt + enter






    }
}
