using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro___homework
{
    public class Faculty
    {
        public string firstName;
        public string lastName;
        public int employeeId;
        public string subjectsTaught;
        public List<string> subjectsTaughtList;

        public Faculty(string firstName, string lastName, int employeeId, List<string> subjectsTaughtList)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeId = employeeId;
            this.subjectsTaughtList = subjectsTaughtList;
        }

        public string GetFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }

        public void GetSubjectsTaught()
        {
            foreach (string elem in subjectsTaughtList)
                Console.WriteLine(elem);
        }
    }
}
