using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _239_OOP_abstract_class_and_property
{
    abstract class BasePerson
    {
        /*
         * man kann nicht von Abstract Class einen Objekt "Instanz" defenieren
         * 
         * du musst den Abstract Class von andere Klassen vererben!!!
         */

        protected string _Name;  // anstat private wird protected gennant ->Scoop(vorhandene Klass + alle davon vererbung Klassen)
        public string address;

        public abstract string Name { get; set; }

        public abstract void PrintData();


    }
}
