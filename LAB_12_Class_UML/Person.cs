using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_12_Class_UML
{
    class Person
    {
        public string name { get; set; }
        public string address { get; set; }
        public Person()
        {
        }
        public Person(string _name, string _address)
        {
            this.name = _name;
            this.address = _address;
        }
        public override string ToString()
        {
            return $"Person [name={this.name},address={this.address}]";
        }
    }
}
