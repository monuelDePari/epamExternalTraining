using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSecondTraining
{
    public class Runner
    {
        public void Run()
        {
            School school = new School();
            Student studentFirst = new Student();
            studentFirst.Age = 25;
            studentFirst.NameOfStudent = "Ivan";
            studentFirst.NumberOfStudent = 55555;
            Student studentSecond = new Student();
            studentSecond.Age = 30;
            studentSecond.NameOfStudent = "Roman";
            studentSecond.NumberOfStudent = 44444;
            Course course = new Course();
            school.AddObserver(studentFirst, course);
            school.AddObserver(studentSecond, course);
            school.GetListOfStudents();
        }
    }
}
