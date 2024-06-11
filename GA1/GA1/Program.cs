using GA1.fisi19;
using GA1.sommer2016;
using GA1.sommer2020;
using GA1.sommer2021;
using GA1.winter2016;
using GA1.winter2018;
using GA1.winter2019;
using GA1.winter2021;
using Sommer2015;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GA1
{
    class Program
    {
        struct MyStruct
        {
            // write code evrythink  a struct can be implement an interface
            // to call, you must an object erstellen
        }
        delegate string mydelegate();
        //delegate void mydelegate();
        static event mydelegate myevent1;  // to crate new event do you have a new delegate

        static void Main(string[] args)
        {

            // propfull
            // Debugging modus press f10

            myevent1 += delegate { Console.WriteLine("Event...ok"); return ""; };
            myevent1();

            // sommer2015
            //Artistengruppe artistg1 = new Artistengruppe("Artist gruppe1", "gerne1", 99.9);
            //Musikgruppe musicg1 = new Musikgruppe("music gruppe1", "rock", 26.5);
            //Kuenstlerliste kl1 = new Kuenstlerliste();
            //kl1.Hinzufuegen(artistg1);
            //kl1.Hinzufuegen(musicg1);
            //Console.WriteLine("Name: " + artistg1.getName());
            //Console.WriteLine("pauschalPreis: " + artistg1.get_pauschalPreis());
            //Console.WriteLine("Name: " + musicg1.getName());
            //Console.WriteLine("preisProStunde: " + musicg1.getpreisProStunde());
            //Console.WriteLine(kl1.GetType());

            // GA1.winter2016;
            //Artikel_1_2 a = new Artikel_1_2(1234567, "test_bez", 99.9);
            //Console.WriteLine("getEinstQS(): " + a.is_valid(123456));

            //winter2018
            //Vigenere crypto = new Vigenere();
            //crypto.setPrivateKey("PRUEFUNG");
            //string klartext = "DERADLERISTGELANDET";
            //crypto.setKlartext(klartext);
            //string codierterText = crypto.codieren();
            //Console.WriteLine("Klartext: {0}", klartext);
            //Console.WriteLine("verschlüsselt: {0}", codierterText);
            //Console.ReadKey();

            // sommer2019
            //SozialesNetzwerk sn = new SozialesNetzwerk();
            //Person pl = new Person("Meier ", "Hans");
            //Person p2 = new Person("Gramm ", "Anna");
            ////Personen dem Netzwerk hinzufügen
            //sn.hinzufuegenMitglied(pl);
            //sn.hinzufuegenMitglied(p2);
            ////Nachricht schreiben 
            //Textnachricht tn1 = new Textnachricht("Morgen ist Schulfrei!", pl);
            //Textnachricht tn2 = new Textnachricht("Alles wird gut", p2);
            //sn.hinzufuegenNachricht(tn1);
            //sn.hinzufuegenNachricht(tn2);
            ////Likes setzen 
            //tn1.hinzufuegenLike();
            //tn1.hinzufuegenLike();
            //Console.WriteLine(sn.getAlleNachrichten());
            //Console.WriteLine(tn1.get_Passwort("as dfg tz uik")); 

            //Reader
            //Testreader c1 = new Testreader();
            //var fileToread = @"C:\Users\tss3\Desktop\LogSkipass.txt";
            //c1.Readtxt(fileToread);
            //var fileTOwrite = @"C:\Users\tss3\Desktop\myOutput.csv";
            //c1.ReadWriteCsv(fileToread, fileTOwrite);

            //winter2019
            //Praxis praxis = new Praxis();
            //praxis.addBehandlung(new Physiobehandlung("A12345", "Chirogymnastik", 12.87));
            //praxis.addBehandlung(new Physiobehandlung("A12345", "Wärmeanwendung", 4.23));
            //praxis.addBehandlung(new Standardbehandlung("A12345", "Arthrose", 45.12));
            //praxis.addBehandlung(new Standardbehandlung(" A12345", "Ultraschall", 26.80));
            //Console.WriteLine("Gesamtkosten: " + praxis.ermittleKosten());

            // sommer2020
            //VipKunde freundl = new VipKunde("Toni Freund", "02342 3333333");
            //VipKunde freundin2 = new VipKunde("Tina Freundinger", "0432 3111111"); 
            //VipKunde klopp = new VipKunde("Johannes Klopp", "01234 4391282", new List<VipKunde> { freundl, freundin2 });
            //klopp.kaufeKarte(24.5, new DateTime(2020, 6, 1), new DateTime(2020, 7, 4)); klopp.kaufeKarte(24.5, new DateTime(2020, 6, 1), new DateTime(2020, 6, 6));
            //double kartenPreis = klopp.berechneKartenPreis();
            //Console.WriteLine("Die Karten kosten: " + kartenPreis);


            // sommer2021
            //Nachrichtenschlange ns1 = new Nachrichtenschlange();
            //Kaffeevollautomat kf1 = new Kaffeevollautomat("1", ns1);
            //kf1.fuelle(700, 70);
            //kf1.erzeugeTasseKaffee(true);
            //kf1.erzeugeTasseKaffee(false);
            //Random random = new Random();
            //int r = random.Next(1, 100);
            //for (int i = 0; i < 30; i++)
            //{
            //    ns1.neueNachricht(new Nachricht(Convert.ToString(r++), "sd"));
            //    ns1.drucke();
            //}

            //winter2021
            //List<string> infolist = new List<string>() { "value1", "value2", "value3" };
            //for (int i = 0; i < infolist.Count; i++)
            //{
            //    Console.WriteLine("Element#{0} = {1}", i, infolist[i]);
            //}
            //Console.WriteLine("Capacity: " + infolist.Capacity);
            //Tablettenform eineTablette = new Tablettenform(2.0, 8.0, 3.0, 200.0, 1508);
            //List<Medikament> medikamentListe = new List<Medikament>();
            //for (int i = 0; i < 60; i++)
            //{
            //    medikamentListe.Add(new Medikament("15.08.2025", "Eucaliptum", "Zur Schmerzlinderung bei Bronchialbeschwerden", 3101, eineTablette));
            //}
            //Blister meinBlister = new Blister(medikamentListe, 2, 6);
            //meinBlister.entnehmen(0, 0);
            //meinBlister.entnehmen(1, 4);
            //meinBlister.druckeBestandInfo();
            //MessageBox.Show("Hallo", "Error", MessageBoxButtons.YesNo);

            //Ab19 ab19 = new Ab19();   //Fisi
            //Console.WriteLine(ab19.pruefeSeriennummer("SE7133131855"));


        }
    }
}
