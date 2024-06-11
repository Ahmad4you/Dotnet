using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2019
{
    public abstract class Nachricht
    {
        private protected int likes;
        private protected Person absender; // asoziation

        public Nachricht()
        {
            this.absender = null;
            this.likes = 0;
        }
        public Nachricht(Person absender)
        {
            this.absender = absender;
            this.likes = 0;
        }

        public void hinzufuegenLike()
        {
            this.likes++;
        }
        public abstract string getNachricht();
    }
}
