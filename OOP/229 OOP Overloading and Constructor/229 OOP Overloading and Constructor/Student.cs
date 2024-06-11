using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _229_OOP_Overloading_and_Constructor
{
    class Student
    {
        public int id;
        public string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Student()  // Constructor +default values
        {
            this.id = -1;
            this.name = "None";
        }

        public void PrintData()
        {
            Console.WriteLine(id + " ; " + name);
        }
    }
}
