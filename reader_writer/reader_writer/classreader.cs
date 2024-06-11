using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reader_writer
{
    class classreader
    {
        public void ReadCsv(string pfad)
        {
            var column1 = new List<string>();
            var column2 = new List<string>();
            var column3 = new List<string>();

            using (var rd = new StreamReader( pfad))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(';');
                    column1.Add(splits[0]);
                    column2.Add(splits[1]);
                    column2.Add(splits[2]);
                }
            }
            // print column1
            Console.WriteLine("Column 1:");
            foreach (var element in column1)
                Console.WriteLine(element);

            // print column2
            Console.WriteLine("Column 2:");
            foreach (var element in column2)
                Console.WriteLine(element);

            // print column3
            Console.WriteLine("Column 3:");
            foreach (var element in column3)
                Console.WriteLine(element);
        }

        public void WriteCsv(string file)
        {
            var stream = File.CreateText(file);
            stream.WriteLine("Hallo");
            stream.Flush();
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
                    
                }
            }
            
            for (int x= Convert.ToInt32(column2RaumNr); x<=255; x++)
            {
                for (int y = Convert.ToInt32(column3PcNr); y <= 255; y++)
                {
                    
                    Console.WriteLine("{0};{1}", column1Mac, "10.16." + x + "." + y);
                    //stream.Write("{0},{1}", "","10.16.");
                    streamWriter.WriteLine("{0};{1}", column1Mac, "10.16." + x + "." + y);
                }  
            }
            streamWriter.Close();
        }


    }
}
