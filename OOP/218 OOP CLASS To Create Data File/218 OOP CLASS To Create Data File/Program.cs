using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _218_OOP_CLASS_To_Create_Data_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tools.CreatDataFile("my new DataFile.txt", new string[] { "Hallo", "Ahmad", "Guten Abend!"});
           
            string[] myFilesName = { "my11.txt", "my2.txt", "my3.txt" };
            string[] line1 = { "Hallo1", "Ahmad1", "Guten Abend1!" };
            string[] line2 = { "Hallo2", "Ahmad2", "Guten Abend2!" };
            string[] line3 = { "Hallo3", "Ahmad3", "Guten Abend3!" };
            string[][] Alllines = { line1, line2, line3};
            Tools.CreatDataFiles(myFilesName, Alllines);
        }
    }
}
