using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210_OOP_Constructor_With_Parameters_in_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();

            Student st = new Student("ABC", "Ahmad", "ERB");
            st.PrintStudentData();


            Student st2 = new Student("EFG", "DIANA", "ERB");
            st2.PrintStudentData();
        }
    }
}
