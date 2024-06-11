using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _228_OOP_inheritance
{
    class Customer : Person
    {
        private string _shipmentAdress;

        public string ShipmentAdress { get => _shipmentAdress; set => _shipmentAdress = value; }
    }
}
