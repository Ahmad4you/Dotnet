using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommer2015.assoziation
{
    class Schuler
    {
        private int _id_Schuler;
        private string _name;
        private string _vorname;
        private string _lehrjahr;

        public int Id_Schuler { get => _id_Schuler; set => _id_Schuler = value; }
        public string Name { get => _name; set => _name = value; }
        public string Vorname { get => _vorname; set => _vorname = value; }
        public string Lehrjahr { get => _lehrjahr; set => _lehrjahr = value; }

        public Schuler(int id_Schuler, string name, string vorname, string lehrjahr)
        {
            _id_Schuler = id_Schuler;
            _name = name;
            _vorname = vorname;
            _lehrjahr = lehrjahr;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
