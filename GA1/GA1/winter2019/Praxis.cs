using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.winter2019
{
    class Praxis
    {
        private List<Patient> patientList;
        private List<Behandlung> behandlungList;

        public Praxis()
        {
            patientList = new List<Patient>();
            behandlungList = new List<Behandlung>();
        }

        public List<Patient> get_Patient(string name)
        {
            List<Patient> patients = new List<Patient>();
            foreach (Patient item in patientList)
            {
                if (item.get_Name().Equals(name))
                {
                    patients.Add(item);
                } 
            }
            return  patients;
        }

        public List<Behandlung> get_Behandlungen(string kvNummer)
        {
            List<Behandlung> behandlungs = new List<Behandlung>();
            foreach (Behandlung item in behandlungList)
            {
                if (item.KvNummer.Equals(kvNummer))
                {
                    behandlungs.Add(item);
                }
            }
            return behandlungs;
        }
        public int anzBehandlungen(string kvNummer)
        {
            int counter = 0;
            foreach (Behandlung item in behandlungList)
            {
                if (item.KvNummer.Equals(kvNummer)) counter++;
            }
            //return get_Behandlungen(kvNummer).Capacity;
            return counter;
        }
        
        public string zeigePatienten(int anzBehandlungen)
        {
            string pName = "";
            foreach (Patient item in patientList)
            {
                if (get_Behandlungen(item.get_KvNummer()).Capacity >= anzBehandlungen)
                {
                    pName += item.get_Name() + "; ";
                }
            }
            return pName;
        }

        public void addBehandlung(Behandlung b)
        {
            behandlungList.Add(b);
        }

        public double ermittleKosten()
        {
            double kosten=0;
            foreach (Behandlung item in behandlungList)
            {
                kosten +=item.get_Kosten();
            }
            return kosten;
        }
    }
}
