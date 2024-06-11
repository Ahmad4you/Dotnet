using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommer2015
{
    abstract class Kuenstlergruppe // Abstract class
    {
        private string name;

        public string getName() { return name; }

        public Kuenstlergruppe(string name)
        {
            this.name = name;
        }
        
        public abstract string GetArt();

    }
}
