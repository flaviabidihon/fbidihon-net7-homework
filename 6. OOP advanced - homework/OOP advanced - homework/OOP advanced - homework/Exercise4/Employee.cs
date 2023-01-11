using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise4
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }


        public abstract double CalculateBonus();

        public virtual string GetContactInfo()
        {
            return " ";
        }
    }

    public enum Department
    {
        HR,
        IT,
        Sales,
        Marketing
    }
}
