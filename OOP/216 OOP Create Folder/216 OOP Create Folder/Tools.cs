using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _216_OOP_Create_Folder
{
    class Tools
    {
        public static void CreatFolder(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
        public static void CreatFolders(string[] paths)
        {
            foreach(string folder in paths)
            {
                CreatFolder(folder);
            }
        }
        public static void CreatEmptyFile(string path)
        {
            if (!File.Exists(path))
                File.Create(path).Close();
        }
        public static void CreatEmptyFiles(string[] paths)
        {
            foreach (string file in paths)
            {
                CreatEmptyFile(file);
            }
        }
    }
}
