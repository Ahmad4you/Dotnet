using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2019
{
    class Textnachricht : Nachricht
    {
        private string nachricht;

        public Textnachricht()
        {
        }

        public Textnachricht(string nachricht, Person absender) :base(absender)
        {
            this.nachricht = nachricht;
        }

        public override string getNachricht()
        {
            string ergebnis= "";
            ergebnis = absender.get_Nachname() + "Nachricht: " + nachricht + " Likes: "+ likes;

            return ergebnis;
        }

        public string get_Passwort(string satz)
        {
            string passwort = "";
            char zeichen = ' ';
            bool grossBuchstabe = true;

            List<string> teilworter = new List<string>();
            teilworter = satz.Split(' ').ToList();
            foreach (var item in teilworter)
            {
                zeichen = item.First();
                if (char.IsLetter(zeichen))
                {
                    if (grossBuchstabe)
                    {
                        zeichen = char.ToUpper(zeichen);
                        grossBuchstabe = false;
                    }
                    else
                    {
                        zeichen = char.ToLower(zeichen);
                        grossBuchstabe = true;
                    }
                }
                passwort += zeichen;
            }
            return passwort;
        }
    }
}
