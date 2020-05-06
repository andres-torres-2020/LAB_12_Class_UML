using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_12_Class_UML
{
    class Student : Person
    {
        private string program { get; set; }
        private int year { get; set; }
        private double fee { get; set; }
        public Student()
        {

        }
        public Student(string _name, string _address, string _program, int _year, double _fee)
            : base(_name, _address)
        {
            program = _program;
            year = _year;
            fee = _fee;
        }
        public override string ToString()
        {
            return $"Student [{base.ToString()},program={this.program},year={this.year},fee={this.fee}]";
        }
    }
}
