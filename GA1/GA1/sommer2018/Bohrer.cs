using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2018
{
    class Bohrer : Werkzeug
    {
        private int groesse;

        public Bohrer(int groesse, string art, int verschleiss) : base(art, verschleiss)
        {
            this.groesse = groesse;
        }

        public override void ausgeben()
        {
            Console.WriteLine($"Bohrer mit Groesse\t {groesse} (Verschleiss\t {verschleiss} %");
        }
    }
}
