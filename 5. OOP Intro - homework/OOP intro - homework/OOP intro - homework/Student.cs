using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro___homework
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public int studentId;
        public double gpa;

        public Student(string firstName, string lastName, int studentId, double gpa)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentId = studentId;
            this.gpa = gpa;
        }

        public string GetFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }

        public bool HasHonors()
        {
            if (this.gpa >= 3.5)
                return true;
            else
                return false;
        }
    }
}
