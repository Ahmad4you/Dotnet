using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _218_OOP_CLASS_To_Create_Data_File
{
    class Tools
    {
        public static void CreatDataFile(string path, string[] lines)
        {
            StreamWriter sw = new StreamWriter(path);
            foreach(string line in lines)
            {
                sw.WriteLine(line);
            }
                sw.Flush();
                sw.Close();
        }
        public static void CreatDataFiles(string[] paths, string[][] AllLines)
        {
            for(int i = 1; i < paths.Count(); i += 1)
            {
                CreatDataFile(paths[i], AllLines[i]);
            }
        }
    }
}
