using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DCH251.Week1
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name { get { return name; } }
        public int Age { get { return age; } }


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
