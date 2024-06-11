using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2016
{
	class Artikel_1_2
	{
		private int art_nr;
		private String art_bez;
		private double preis;


		public void setArt_nr(int art_nr)
		{
			this.art_nr = art_nr;
		}

		public void setArt_bez(String art_bez)
		{
			this.art_bez = art_bez;
		}

		public void setPreis(double preis)
		{
			this.preis = preis;
		}

		public int getArt_nr()
        {
			return art_nr;
		}
		public String getArt_bez()
        {
			return art_bez;
        }
		public double getPreis()
        {
			return preis;
        }

		public Artikel_1_2(int art_nr, String art_bez, double preis)
		{
			this.art_nr = art_nr;
			this.art_bez = art_bez;
			this.preis = preis;
		}




		public int getEinstQS(int art_nr)
        {

			int einstQS;
			int art_nr_6st = (int)art_nr / 10;
			do
			{
				einstQS = 0;

                while(art_nr_6st != 0){
					einstQS = einstQS + art_nr_6st % 10;
					art_nr_6st = art_nr_6st / 10;
				}

				art_nr_6st = einstQS;
			} while (art_nr_6st > 9);
			
				return einstQS;
        }

		public bool is_valid(int art_nr)
        {
            //int pruefz = art_nr % 10;
            //return (getEinstQS(art_nr) == pruefz);
            if (getEinstQS(art_nr) == art_nr % 10) return true;
            else return false;
        }
	}

}
