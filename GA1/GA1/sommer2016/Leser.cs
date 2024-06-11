using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.sommer2016
{
    class Leser
    {
        private int leserNr;
        private String vorname;
        private String name;
        private List<Medium> ausleihliste;
        private List<Medium> vormerkliste;

        public Leser(int leserNr, string vorname, string name)
        {
            this.leserNr = leserNr;
            this.vorname = vorname;
            this.name = name;
            this.ausleihliste = new List<Medium>();
            this.vormerkliste = new List<Medium>();
        }

        public int LeserNr { get => leserNr; set => leserNr = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Name { get => name; set => name = value; }

        public List<Medium> setAusleihliste { set => ausleihliste = value; }
        public List<Medium> setVormerkliste { set => vormerkliste = value; }
        public List<Medium> getAusleihliste { get => ausleihliste; }
        public List<Medium> getVormerkliste { get => vormerkliste; }

        public bool hatAusgeliehen(int bibNr)
        {
            foreach (Medium item in getAusleihliste)
            {
                if (item.getBibNr == bibNr)
                    return true;
            }
            return false;
        }

        //Hörbuch h = new Hörbuch();
        //if(Object instanceof getAusleihliste)
        //{
        //    if (((getAusleihliste)object).size() > 0 && (((getAusleihliste)object).get(0) instanceof Medium)){
        //        // The object is of List<MyObject> and is not empty. Do something with it.
        //    }
        //}

        public void printobjType(object o)
        {
            //typeof(o)
            //o.GetType().Name;
            if (o is int) Console.WriteLine("INT");
            else if (o is double) Console.WriteLine("double");
            else if (o is string) Console.WriteLine("string");
            else if (o is bool) Console.WriteLine("bool");
            else Console.WriteLine(o.GetType().Name);
        }



    }
}
