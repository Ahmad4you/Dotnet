using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210_OOP_Constructor_With_Parameters_in_Class
{
    class Student
    {
        public Student(string code, string name, string branche)
        {
            this.code = code ;
            this.name = name;
            this.branche = branche;
        }
        public string code;
        public string name;
        public string branche;

        public void PrintStudentData()
        {
            string allData = "Code: " + code + "\nName: " + name + "\nBranche: " + branche + "\n";
            Console.WriteLine(allData);
        }
    }
}
