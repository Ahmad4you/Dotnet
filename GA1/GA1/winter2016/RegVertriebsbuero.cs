using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GA1
{
    public class RegVertriebsbuero : Kunde
    {
        private string bezeichnung;
        private double provisionsatz;

        public Bestellung Bestellung
        {
            get => default;
            set
            {
            }
        }
    }
}