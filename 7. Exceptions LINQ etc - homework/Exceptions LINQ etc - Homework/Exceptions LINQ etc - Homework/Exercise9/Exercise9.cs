using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ_etc___Homework.Exercise9
{
    public static class Exercise9
    {
        public static void Run()
        {
            var students = new List<Student>
            {
                new Student("Alice", "A"),
                new Student("Bob", "B"),
                new Student("Charlie", "A"),
                new Student("Dave", "C"),
            };

            var query = students.Where(s => s.Grade == "A")
                .OrderByDescending(s => s.Name)
                .Select(s => new {Name = s.Name});

            foreach(var student in query)
            Console.WriteLine(student.Name); 
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Grade { get; set; }

        public Student(string name, string grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
