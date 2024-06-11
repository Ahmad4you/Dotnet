using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2016
{
    abstract class Medium
    {
        private int bibNr;

        public int getBibNr
        {
            get { return bibNr; }
          
        }
        public int setBibNr
        {
            set { bibNr = value; }

        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string zustand;

        public string Zustand
        {
            get { return zustand; }
            set { zustand = value; }
        }


    }
}
