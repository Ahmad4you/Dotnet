using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _228_OOP_inheritance
{
    class Person
    {
        private string _name;
        private string _adress;
        private string _phone;
        public bool isActive;

        public Person()
        {
        }

        public Person(string name, string adress, string phone, bool isActive)
        {
            _name = name;
            _adress = adress;
            _phone = phone;
            this.isActive = isActive;
        }

        public string Name { get => _name; set => _name = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _GetPersonData()
        {
            return _name + ";" + _adress + ";" + _phone;
        }
        public string GetPersonData()
        {
            return _GetPersonData().Replace(";", "\n");
        }
        public void PrintPersonData()
        {
            Console.WriteLine(GetPersonData());
        }
        
    }
}
