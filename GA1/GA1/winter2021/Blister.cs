using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2021
{
    class Blister
    {
        private List<Medikament> medikamenteListe;
        private int anzahlMulden;
        private int anzahlReihen;
        private int anzahlSpalten;
        private int anzahlMedikamente;
        private long id;
        private bool[,] bestandInfo;

        public Blister(List<Medikament> produzierteMedikamente, int anzahlReihen, int anzahlSpalten)
        {
            this.medikamenteListe = new List<Medikament>();
            this.anzahlReihen = anzahlReihen;
            this.anzahlSpalten = anzahlSpalten;
            anzahlMulden = anzahlReihen * anzahlSpalten;

            for (int i = 0; i < anzahlMulden; i++)
            {
                this.medikamenteListe.Add(produzierteMedikamente[i]);
            }

            anzahlMedikamente = medikamenteListe.Count;
            //bestandInfo = new bool[anzahlReihen][anzahlSpalten];
            bestandInfo = new bool[anzahlReihen, anzahlSpalten];
            if (anzahlMulden == anzahlMedikamente)
            {
                for (int i = 0; i < anzahlReihen; i++)
                {
                    for (int j = 0; j < anzahlSpalten; j++)
                    {
                        bestandInfo[i, j] = true;
                    }
                }
            }
            else { anzahlMedikamente = -1; }
        }

        public bool entnehmen(int indexReihe, int indexSpalte)
        {
            bool ruckgabewert = false;
            if (bestandInfo[indexReihe, indexSpalte] == true)
            {
                bestandInfo[indexReihe, indexSpalte] = false;
                medikamenteListe.RemoveAt(medikamenteListe.Count -1);
                ruckgabewert = true;
            }
            return ruckgabewert;
        }
        public void druckeBestandInfo()
        {
            for (int i = 0; i < anzahlReihen; i++)
            {
                for (int j = 0; j < anzahlSpalten; j++)
                {
                    if (bestandInfo[i, j] == true)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("X ");
                    }
                    //bestandInfo[i, j] = true;
                }
                Console.WriteLine("");
            }

        }


    }
}
