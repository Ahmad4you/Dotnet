using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2018
{
    public abstract class Werkzeug
    {
        private string art;
        private protected int verschleiss;

        public Werkzeug(string art, int verschleiss)
        {
            this.art = art;
            this.verschleiss = 0;
            if (verschleiss >= 0 && verschleiss <= 100)
                this.verschleiss = verschleiss;
        }

        public abstract void ausgeben();
    }

}
