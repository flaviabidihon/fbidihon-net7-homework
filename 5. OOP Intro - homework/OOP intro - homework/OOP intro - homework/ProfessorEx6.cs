using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro___homework
{
    public class ProfessorEx6
    {
        public string name;
        //public string faculty; 
        public CollegeEx6 faculty;
        public string specialization;
        public List<string> studentsWhoGiveTheirDegree;

        public ProfessorEx6(string name, CollegeEx6 faculty, string specialization)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;

            //AICI M-AM IMPOTMOLIT PUTIN. NU STIU EXACT CUM SA LE COMPAR

            //if (this.faculty !=
            //    throw new Exception("The student and the professor are not from the same school institution.");
            //else
            //    Console.WriteLine("College and faculty are the same. Let the exam begin!");
        }

        public ProfessorEx6(string name, CollegeEx6 faculty, string specialization, List<string> studentsWhoGiveTheirDegree)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;
            this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
        }

        public void AddStudent(string student)
        {
            this.studentsWhoGiveTheirDegree.Add(student);
        }
        
        public void RemoveStudent(string student)
        {
            this.studentsWhoGiveTheirDegree.Remove(student);
        }

        public void PrintStudents()
        {
            foreach(string student in studentsWhoGiveTheirDegree)
                Console.WriteLine(student);
        }
    }
}
