﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_School_Solution
{
    class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public override string ToString() { 
            return name;
        }
    }
}
