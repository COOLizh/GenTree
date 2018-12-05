using System;
using System.Collections.Generic;
using System.Text;

namespace GenTree.Models
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DoB { get; set; }
        public bool Gender { get; set; }

        //public bool MoB { get; set; }
        //public bool SoB { get; set; }
        //public bool Children { get; set; }
        //public bool Spouse { get; set; }

        public Dictionary<Person, string> Persons;
    }
}
