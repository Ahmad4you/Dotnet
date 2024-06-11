using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _239_OOP_abstract_class_and_property
{
    class Employee : BasePerson
    {
        
        public override string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        

        public override void PrintData()
        {
            Console.WriteLine(_Name + " ; " + address);
        }

        public Employee()
        {
            Console.WriteLine("constructor is called");
        }

        ~Employee()
        {
            Console.WriteLine("constructor is destroyed");
        }
    }
}
