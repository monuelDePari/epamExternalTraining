using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSecondTrainin
{
    public class Runner
    {
        public void Run()
        {
            School school = new School();
            Course course = new Course();
            Student student = new Student();
            student.NameOfStudent = "Ivan";
            student.Age = 29;
            student.NumberOfStudent = 22222;
            Student studentSecond = new Student();
            studentSecond.NameOfStudent = "Ivan";
            studentSecond.Age = 29;
            studentSecond.NumberOfStudent = 22222;
            school.AddObserver(student, course);
            school.GetListOfStudents();
        }
    }
}
