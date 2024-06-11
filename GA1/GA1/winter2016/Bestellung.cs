using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GA1
{
    public class Bestellung
    {
        private int bestellNr;
        private string bestelldatum;
        private List<Position> positionen;

        public Position Position
        {
            get => default;
            set
            {
            }
        }
    }
}