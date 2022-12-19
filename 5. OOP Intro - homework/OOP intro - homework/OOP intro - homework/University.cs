using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro___homework
{
    public class University
    {
        public string name;
        public List<Student> students;
        public List<Faculty> faculties;

        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void AddFaculty(Faculty faculty)
        {
            this.faculties.Add(faculty);
        }

        public int GetStudentCount()
        {
            return this.students.Count();
        }

        public int GetFacultyCount()
        {
            return this.faculties.Count();
        }
    }
}
