using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1.fisi19
{
    class Ab19
    {


        //      Aus den ersten elf Zeichen lässt sich die Prüfziffer wie folgt errechnen:
        //1.	Die zwei Buchstaben werden durch die Zahl ihrer Reihenfolge im Alphabet ersetzt
        //      (also A = 1, Z = 26).
        //2.	Aus den zwei in Schritt 1 ermittelten Zahlen und der 9-stelligen Nummer wird
        //      eine Quersumme gebildet.
        //3.	Die Quersumme wird durch 9 dividiert und der Rest aus dieser Division ermittelt.
        //4.	Dieser Rest wird nun von 7 abgezogen, das Ergebnis ergibt die Prüfziffer.

        //      Auf einem Geldschein ist z.B.die Seriennummer „SE7133131855" aufgedruckt.
        //      Somit ergibt sich:
        //      Kennzeichen der Druckerei:	SE
        //      Seriennummer(9-stellig) :   713313185
        //      Prüfziffer:	5



        public bool pruefeSeriennummer(String eingabe)
        { 
            int pruefziffer = Convert.ToInt32(eingabe.Substring(eingabe.Length - 1)); //5
            string seriennummer = eingabe.Substring(0, eingabe.Length - 1); //SE713313185
           
            string sNrAsInteger = ""; // Wert von 2 char + 9 Zahlen
            foreach (char c in seriennummer)
            {
                if (!char.IsNumber(c))
                {
                    int charAsNr = Convert.ToInt32(c);
                    int revelantNr = charAsNr - 64;
                    sNrAsInteger += revelantNr;
                    continue;
                }
                sNrAsInteger += c;
            }
            long qsumme = Convert.ToInt64(sNrAsInteger);
            long rest = 7 - (qsumme % 9);

            if (rest == pruefziffer)
            {
                return true;
            }
            return false;
        }
        
        public void fisi()
        {
            //Ceate the file Rechnerlste.csv in 👇.
            //C:\Users\User\source\repos\ConsoleApp18\ConsoleApp18\bin\Debug\netcoreapp3.1

            //Put the original Adress in 🖐.
            //MAC,RNummer;PCNr
            //9C:8E:76:66:3F;201;1;

            //Create a String array to read every line in the file 📑.
            string[] lines = File.ReadAllLines(@"Rechnerlste.csv");

            //Create a String array or list to write every line in Hostliste.csv the file 📝.
            List<string> newlines = new List<string>();

            //Create foreach or for to read every single line in Rechnerlste.csv 📑.
            foreach (var line in lines)
            {
                //Split the line with ; 🙄.
                string[] parts = line.Split(';');

                //How schould lokk like at the End (●'◡'●).
                //MAC;10.16.RNummer.PCNr
                newlines.Add(parts[0] + ";10.16." + parts[1] + "." + parts[2]);
            }
            //Write the Adress in new file 🎉✨🎈🎃.
            File.WriteAllLines("Hostliste.csv", newlines, Encoding.UTF8);

        }

    }
}
