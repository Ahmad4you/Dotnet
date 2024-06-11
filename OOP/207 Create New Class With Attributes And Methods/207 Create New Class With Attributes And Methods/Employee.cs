using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _207_Create_New_Class_With_Attributes_And_Methods
{
    class Employee
    {
        public int id;
        public string name;
        public string address;
        public string phone;
        public double salary;
        const double tax = 0.1;
        
        public double GetNetSalary()
        {
            double netSalary = salary - (salary * tax);
            return netSalary;
        }

        public string GetEmployeeData()
        {
            string allData = "ID: " + id + "\n";
            allData += "Name: " + name + "\n";
            allData += "Address: " + address + "\n";
            allData += "Phone: " + phone + "\n";
            allData += "Salary: " + salary + "\n";
            allData += "NetSalary: " + GetNetSalary() + "\n";
            return allData; 
        }

        public void PrintEmployeeData()
        {
            Console.WriteLine(GetEmployeeData());
        }
    }
}
