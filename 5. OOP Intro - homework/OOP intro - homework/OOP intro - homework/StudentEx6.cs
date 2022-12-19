using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro___homework
{
    public class StudentEx6
    {
        public string name;
        public DateTime startDate;
        public DateTime endDate;
        public CollegeEx6 college;
        public DateTime birthDate;

        public StudentEx6(string name, DateTime startDate, DateTime endDate, CollegeEx6 college, DateTime birthDate)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.college = college;
            this.birthDate = birthDate;
        }

        public bool IsStillStudent()
        {
            if (endDate < DateTime.Now)
                return false;
            else
                return true;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - this.birthDate.Year;
        }

        public void Print()
        {
            Console.WriteLine($"Name is {this.name}, age is {this.GetAge()} and is going to {college.name}.");
        }
    }
}
