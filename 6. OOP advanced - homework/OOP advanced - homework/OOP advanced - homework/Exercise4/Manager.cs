using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise4
{
    public class Manager : Employee
    {
        private Department _department;
        private string _name;
        private int _age;
        private double _salary;


        public Manager(string name, int age, double salary, Department department)
        {
            _name = name;
            _age = age;
            _salary = salary;
            _department = department;
        }

        public override double CalculateBonus()
        {
            return _salary * 0.1;
        }

        public override string GetContactInfo()
        {
            return $"Name: {_name}, Age: {_age}, Department: {_department}";
        }
    }
}
