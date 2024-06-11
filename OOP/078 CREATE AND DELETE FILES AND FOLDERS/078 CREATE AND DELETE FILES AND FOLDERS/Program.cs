using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace _078_CREATE_AND_DELETE_FILES_AND_FOLDERS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("my Folder");
            //Directory.CreateDirectory("C:\\my Folder");
            //Directory.Delete("my Folder");
            //StreamWriter sw = new StreamWriter("myFile.txt");
            //StreamWriter sw = new StreamWriter("myFile.txt", true); // true= add new text to old text
            StreamWriter sw = new StreamWriter("myFile.txt", false, Encoding.Unicode);
            sw.WriteLine("Hallo Ahmad");
            sw.WriteLine("Hallo ❤💝O.O*_*");
            sw.Close();       //ohne close wird es kein wort geschreieben

            //File.Delete("myFile.txt");
        }
    }
}
