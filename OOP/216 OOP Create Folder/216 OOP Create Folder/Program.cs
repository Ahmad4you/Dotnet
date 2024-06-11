using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216_OOP_Create_Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Tools.CreatFolder("MyFolder");

            string[] folders = { "my1", "my2", "my3" };
            Tools.CreatFolders(folders);

            Tools.CreatEmptyFile("Myfile.txt");

            string[] fils = { "my1.txt", "my2.txt", "my3.txt" };
            Tools.CreatEmptyFiles(fils);
        }

    }
}
