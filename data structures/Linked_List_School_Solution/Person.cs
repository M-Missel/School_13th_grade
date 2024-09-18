using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerketteteListe
{
    internal class Person
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

        public override bool Equals(object obj)
        {
            Person person = (Person)obj;
            return this.name == person.getName();
        }

        public override string ToString()
        {
            return name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
