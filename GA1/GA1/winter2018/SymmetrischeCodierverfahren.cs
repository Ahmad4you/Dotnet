using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2018
{
    public abstract class SymmetrischeCodierverfahren
    {
        protected string klarText;
        protected string privateKey;

        public SymmetrischeCodierverfahren()
        {
            klarText = "DIESISTEINEBOTSCHAFT"; 
            privateKey = "GEHEIM";
        }

        public void setPrivateKey(string key) {
            this.privateKey = key;
        }

        public string getKlarText()
        {
            return klarText;
        }

        public void setKlartext(string text)
        {
            this.klarText = text;
        }

        public abstract string codieren();
    }
}
