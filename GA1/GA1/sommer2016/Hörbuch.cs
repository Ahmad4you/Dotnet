using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2016
{
    class Hörbuch : Medium
    {
        int hörbücher = 0;
        private int dauer;

        public int Dauer
        {
            get { return dauer; }
            set { dauer = value; }
        }


        //        foreach (Medium m in larsesAusleihliste)
        //        {
        //            if(m is Hörbuch) // testet, ob m als Typ "Hörbuch" / ein kompatibler Typ (z.B. Untertyp) ist
        //            {
        //                hörbücher++;
        //            }
        //// Java: if(m instanceof Hörbuch)


        //// as-Operator:
        //object o = null; // irgendwas
        //Hörbuch h = (Hörbuch)o; // klappt, wenn "o is Hörbuch"
        //                        // falls nicht: InvalidCastException
        //Hörbuch h2 = o as Hörbuch; // wenn "o is Hörbuch" -> wie oben
        //                           // else: null


    }
}
