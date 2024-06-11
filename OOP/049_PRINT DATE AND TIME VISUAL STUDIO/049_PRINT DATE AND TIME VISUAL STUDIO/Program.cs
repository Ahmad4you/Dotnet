using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_PRINT_DATE_AND_TIME_VISUAL_STUDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //string strDt;
            //strDt = DateTime.Now.ToString();
            //Console.WriteLine(strDt);

            //Console.WriteLine(DateTime.Now);

            //DateTime dt = Convert.ToDateTime("01.01.2021 08:10:22 PM");
            //Console.WriteLine(dt);

            string strDt;
            //strDt = DateTime.Now.ToString("d");
            //strDt = DateTime.Now.ToString("D");
            //strDt = DateTime.Now.ToString("t");
            //strDt = DateTime.Now.ToString("T");
            //strDt = DateTime.Now.ToString("dd");
            //strDt = DateTime.Now.ToString("MM");
            //strDt = DateTime.Now.ToString("yyyy");
            //strDt = DateTime.Now.ToString("yy");
            //strDt = DateTime.Now.ToString("y"); 
            //strDt = DateTime.Now.ToString("dd-MM-yyyy");
            //strDt = DateTime.Now.ToString("hh");
            //strDt = DateTime.Now.ToString("mm");
            //strDt = DateTime.Now.ToString("hh:mm:ss tt");
            //strDt = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt");
            //Console.WriteLine(strDt);

            //Console.WriteLine(DateTime.Now.Day);
            //Console.WriteLine(DateTime.Now.Month);
            //Console.WriteLine(DateTime.Now.Year);
            //Console.WriteLine(DateTime.Now.Hour);
            //Console.WriteLine(DateTime.Now.AddDays(5).ToString("dd.MM.yyyy  hh:mm:ss tt"));
            //Console.WriteLine(DateTime.Now.AddYears(5).AddMonths(3).AddDays(7));

            //DateTime dt = Convert.ToDateTime("01.01.2000");
            //for (int x = 1; x <= 12; x++)
            //{
            //    Console.WriteLine(dt.ToString("MMMM"));
            //    dt = dt.AddMonths(1);
            //}

            DateTime dt = Convert.ToDateTime("01.01.2020");
            for (int x = 1; x <= 7; x++)
            {
                Console.WriteLine(dt.ToString("dddd"));
                dt = dt.AddDays(1);
            }

        }
    }
}
