using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_12_Class_UML
{
    class Staff : Person
    {
        private string school { get; set; }
        private double pay { get; set; }
        public Staff()
        {
        }
        public Staff(string _name, string _address, string _school, double _pay)
            : base(_name, _address)
        {
            school = _school;
            pay = _pay;
        }
        public override string ToString()
        {
            return $"Staff [{base.ToString()},school={this.school},pay={this.pay}]";
        }
    }
}
