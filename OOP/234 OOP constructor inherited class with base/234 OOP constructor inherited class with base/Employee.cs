﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _234_OOP_constructor_inherited_class_with_base
{
    class Employee : Person
    {
        public Employee(string type = "Employee") : base(type)
        {

        }

        //public Employee() : base(false)
        //{

        //}
    }
}
