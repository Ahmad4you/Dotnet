using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GA1
{
    class Testreader
    {
        //public void Readtxt(string pfad)
        //{
        //    var column1 = new List<string>();   // List für Datum
        //    var column2 = new List<string>();
        //    var column3 = new List<string>();
        //    var column4 = new List<string>();
        //    var column5 = new List<string>();
        //    var column6 = new List<string>();


        //    using (var rd = new StreamReader(pfad)) // we need Reader to read text file
        //    {
        //        while (!rd.EndOfStream) 
        //        {
        //            var splits = rd.ReadLine().Split('|'); // spliter 

        //            column1.Add(splits[0]);  // to read Datum
        //            column2.Add(splits[1]);  // to read time
        //            column3.Add(splits[2]);
        //            column4.Add(splits[3]);
        //            column5.Add(splits[4]);
        //            column6.Add(splits[5]);

        //        }
        //        rd.Close();
        //    }


        //    // print column1
        //    Console.WriteLine("Column 1:");
        //    foreach (var element in column1)
        //        Console.WriteLine(element);


        //    // print column2
        //    Console.WriteLine("Column 2:");
        //    foreach (var element in column2)
        //        Console.WriteLine(element);

        //    // print column3
        //    Console.WriteLine("Column 3:");
        //    foreach (var element in column3)
        //        Console.WriteLine(element);

        //    // print column4
        //    Console.WriteLine("Column 4:");
        //    foreach (var element in column4)
        //        Console.WriteLine(element);

        //    // print column5
        //    Console.WriteLine("Column 5:");
        //    foreach (var element in column5)
        //        Console.WriteLine(element);

        //    // print column6
        //    Console.WriteLine("Column 6:");
        //    foreach (var element in column6)
        //        Console.WriteLine(element);
        //}

        public void Readtxt(string pfad)
        {
            var allData = new List<string>();   // List for all data from text file

            StreamReader rd = new StreamReader(pfad); // we need StramReader to read text file
            //Console.WriteLine(rd.ReadToEnd() ); 
            while (!rd.EndOfStream)
            {
                var splits = rd.ReadLine(); // to read line from file
                allData.Add(splits);
            }
            Console.WriteLine("All Data:");
            foreach (var element in allData)
                Console.WriteLine(element);        // to write line in Console
            rd.Close();
        }


        public void ReadWriteCsv(string pfad, string file)
        {
            var streamWriter = File.CreateText(file);
            var column1Mac = "";
            var column2RaumNr = "";
            var column3PcNr = "";

            using (var streamReader = new StreamReader(pfad))
            {
                while (!streamReader.EndOfStream)
                {
                    var splits = streamReader.ReadLine().Split(';');
                    column1Mac = splits[0];
                    column2RaumNr = splits[1];
                    column3PcNr = splits[2];

                    streamWriter.WriteLine("{0};{1}", column1Mac,";"+ "10.16." + column2RaumNr + "." + column3PcNr+ ";");
                }
            }
            

            //for (int x = Convert.ToInt32(column2RaumNr); x <= 255; x++)
            //{
            //    for (int y = Convert.ToInt32(column3PcNr); y <= 255; y++)
            //    {

            //        Console.WriteLine("{0};{1}", column1Mac, "10.16." + x + "." + y);
            //        //stream.Write("{0},{1}", "","10.16.");
            //        streamWriter.WriteLine("{0};{1}", column1Mac, "10.16." + x + "." + y);
            //    }
            //}
            streamWriter.Close();
        }

    }
}
