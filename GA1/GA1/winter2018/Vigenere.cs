using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2018
{
    class Vigenere : SymmetrischeCodierverfahren
    {
        public override string codieren()
        {
            string geheim = "";
            int k = 0;
            
            for(int i = 0; i < klarText.Length; i++)
            {

                geheim += (char)((klarText[i] + privateKey[k] - 2 * 'A') % 26 + 'A');
                //geheim += (char)((klarText[i] + privateKey[k]) % 26);
                k++;
                k = k % (base.privateKey.Length);  // 5 % 5 = 0    4%5 == 4
            }
            return geheim;
        }
    }
}
