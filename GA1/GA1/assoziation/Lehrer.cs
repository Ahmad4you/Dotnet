using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommer2015.assoziation
{
    class Lehrer
    {

        private int _id_Lehrer;
        private string _name;
        private string _vorname;
        private string _fach;
        public List<Schuler> schulers;

        public int Id_Lehrer { get => _id_Lehrer; set => _id_Lehrer = value; }
        public string Name { get => _name; set => _name = value; }
        public string Vorname { get => _vorname; set => _vorname = value; }
        public string Fach { get => _fach; set => _fach = value; }

        public Lehrer(int id_Lehrer, string name, string vorname, string fach, List<Schuler> schulers)
        {
            _id_Lehrer = id_Lehrer;
            _name = name;
            _vorname = vorname;
            _fach = fach;
            this.schulers = new List<Schuler>();
            this.schulers = schulers;
        }

        public override string ToString()
        {
            return "id_Lehrer:" + _id_Lehrer + " \n_name:" + _name;
        }
    }
}
