using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise4
{
    public class Developer : Employee
    {
        private List<string> _skills = new List<string>();
        private bool _isJunior;
        private string _name;
        private int _age;
        private double _salary;

        public Developer(string name, int age, double salary, List<string> skills, bool isJunior)
        {
            _skills = skills;
            _isJunior = isJunior;
            _name = name;
            _age = age;
            _salary = salary;
        }

        public override double CalculateBonus()
        {
            return _salary * 0.2;
        }

        public override string GetContactInfo()
        {
            return $"Name: {_name}, Age: {_age}, Skills: {_skills}";
        }
    }
}
