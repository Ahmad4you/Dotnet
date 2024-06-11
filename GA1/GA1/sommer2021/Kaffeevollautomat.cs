using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2021
{
    class Kaffeevollautomat : Geraet
    {
        private int milch;

        public int Milch
        {
            get { return milch; }
            set { milch = value; }
        }
        private int kaffee;

        public int Kaffee
        {
            get { return kaffee; }
            set { kaffee = value; }
        }
        private int tassen;

        public int Tassen
        {
            get { return tassen; }
            set { tassen = value; }
        }

        /*
        * beim Vererbung zu der Master-class{Geraet}, protected attribute sollen kein Wert zuweisen 
        */
        public Kaffeevollautomat(string id, Nachrichtenschlange nachrichtenschlange) : base(id, nachrichtenschlange)
        {
            this.milch = 0;
            this.kaffee = 0;
            this.tassen = 0;
        }

        public void fuelle(int kaffee, int milch)
        {
            if (kaffee != 0 || milch != 0)
            {
                this.milch += Math.Abs(milch);
                this.kaffee += Math.Abs(kaffee);
            }
        }
        public void erzeugeTasseKaffee(bool mitMilch)
        {
            if (defekt == true) // !defekt
            {
                if ( tassen%50 ==0) // 2% der gesamt Tassen
                {
                    Console.WriteLine("Mahlwerk der Maschine ist defekt");
                    defekt = true;
                }
                
            }
            else
            {
                if (mitMilch)
                {
                    if (kaffee >= 25 && milch >= 10)
                    {
                        Console.WriteLine("1 Tasse wurde erzeugt mit Milch");
                        kaffee -= 25;
                        milch -= 10;
                        this.tassen++;
                    }
                    else
                    {
                        if (kaffee < 25) {
                            Console.WriteLine("Kaffe ist Knapp"); }
                        else if (milch < 10) {
                            Console.WriteLine("Milch ist Knapp");
                        }
                                
                    }
                }
                else
                {
                    if (kaffee >= 25)
                    {
                        Console.WriteLine("1 Tasse wurde erzeugt ohne Milch");
                        kaffee -= 25;
                        this.tassen++;
                        if (tassen % 10 == 0)
                        {
                            Console.WriteLine("Gesamt Tassen    : " + tassen);
                        }
                    }
                    else { Console.WriteLine("Kaffe ist Knapp"); }
                }


            }
        }


    }
}
