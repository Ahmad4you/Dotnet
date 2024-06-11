using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Aufgabe2_XML
{
    class Currency
    {
        static void Main(string[] args)
        {
            string currencyCode;
            decimal rate;
             
            string file = @"C:\Users\tss3\Desktop\eurofxref.xml";
            List<Object> CurrencyList = new List<Object>();

            using (XmlReader reader = XmlReader.Create(file))
            {

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        currencyCode = reader.GetAttribute("currency");
                        rate = Convert.ToDecimal(reader.GetAttribute("rate"));
                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "gesmes:subject":
                                Console.WriteLine("subject: " + reader.ReadString());
                                break;
                            case "gesmes:name":
                                Console.WriteLine("name: " + reader.ReadString());
                                break;
                            case "Cube":
                                Console.WriteLine("currency: " + reader.GetAttribute("currency") + "  " + "rate: " + reader.GetAttribute("rate"));
                                
                                CurrencyList.Add("currency: " + currencyCode + "     " +"rate "+ rate);
                                //CurrencyList.Add(rate);
                                break;
                        }
                    }
                    Console.WriteLine("");
                    if(reader.NodeType == XmlNodeType.Element)
                    {
                        Console.WriteLine("it is Element!!");
                    }else if (reader.NodeType == XmlNodeType.Attribute)
                    {
                        Console.WriteLine("it is Attribute!!");
                    }
                    else if (reader.NodeType == XmlNodeType.Text)
                    {
                        Console.WriteLine("it is Text!!");
                    }
                    else if (reader.NodeType == XmlNodeType.Comment)
                    {
                        Console.WriteLine("it is Comment!!");
                    }

                    
                }
            }

            
            foreach(Object o in CurrencyList)
            {
                Console.WriteLine(o);
            }

        }
    }
}
