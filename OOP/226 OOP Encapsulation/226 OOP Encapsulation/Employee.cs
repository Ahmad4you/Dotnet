using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226_OOP_Encapsulation
{
    class Employee
    {
        private int _id;
        private string _name;
        private double _salary;

        public int Id { get => _id; set => _id = value; }
        public string Name { get { return _name; } set { _name = value; } }

        public double Salary { get => _salary; set
            {
                if (value < 5000) value = 5000;
                _salary = value;
            }
        } 
                

        //public double Salary { 
        //    get { return _salary; } 
        //    set 
        //    {
        //        if (value < 5000) value = 5000;
        //        _salary = value; 
        //    } 
        //}

        private string _PrintData()
        {
            return _id + ";" + _name + ";" + _salary;
        }
        public void PrintData()
        {
            Console.WriteLine(_PrintData().Replace(";", "\n"));
        }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   _salary == employee._salary;
        }
    }
}
