using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace GenTree.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DoB { get; set; }
        public string Gender { get; set; }
        public string Id { get; set; }
    }
}
