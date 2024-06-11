using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _238_OOP_Polymorphism
{
    class Program
    {
        static void IamAll(Person pAll)
        {
            pAll.Iam();
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            Customer c = new Customer();
            Employee e = new Employee();

            //p.Iam();
            //c.Iam();
            //e.Iam();
            IamAll(p);
            IamAll(c);
            IamAll(e);
        }
    }
    class Person
    {
        public virtual void Iam()
        {
            Console.WriteLine("I am a Person");
        }
    }
    class Customer : Person
    {
        public override void Iam()
        {
            Console.WriteLine("I am a Customer");
        }
    }
    class Employee : Person
    {
        public override void Iam()
        {
            Console.WriteLine("I am a Employee");
        }
    }
}
