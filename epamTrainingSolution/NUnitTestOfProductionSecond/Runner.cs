using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProductionSecondTrainin;

namespace NUnitTestOfProductionSecond
{
    [TestFixture]
    public class Runner
    {
        [Test]
        public void CheckAge()
        {
            School school = new School();
            Course course = new Course();
            Student student = new Student();
            student.NameOfStudent = "Roman";
            student.Age = 29;
            student.NumberOfStudent = 22222;
            Student studentSecond = new Student();
            studentSecond.NameOfStudent = "Ivan";
            studentSecond.Age = 15;
            studentSecond.NumberOfStudent = 33333;
            school.AddObserver(student, course);
            foreach (var item in course.GetListOfStudents())
            {
                Assert.Greater(30, item.Age);
            }
        }
        [Test]
        public void CheckName()
        {
            School school = new School();
            Course course = new Course();
            Student student = new Student();
            student.NameOfStudent = "Roman";
            student.Age = 29;
            student.NumberOfStudent = 22222;
            Student studentSecond = new Student();
            studentSecond.NameOfStudent = "Ivan";
            studentSecond.Age = 15;
            studentSecond.NumberOfStudent = 33333;
            school.AddObserver(student, course);
            foreach (var item in school.GetListOfStudents())
            {
                Assert.IsNotNull(item);
            }
        }
        [Test]
        public void CheckUniqueNumber()
        {
            School school = new School();
            Course course = new Course();
            Student student = new Student();
            student.NameOfStudent = "Roman";
            student.Age = 29;
            student.NumberOfStudent = 22222;
            Student studentSecond = new Student();
            studentSecond.NameOfStudent = "Ivan";
            studentSecond.Age = 15;
            studentSecond.NumberOfStudent = 33333;
            school.AddObserver(student, course);
            var listOfStudents = school.GetListOfStudents();
            List<int> numbersOfStudent = new List<int>();
            foreach (var item in listOfStudents)
            {
                numbersOfStudent.Add(item.NumberOfStudent);
            }
            List<int> toCompare = numbersOfStudent.Distinct().ToList();
            foreach (var item in school.GetListOfStudents())
            {
                Assert.AreEqual(numbersOfStudent, toCompare);
            }
        }
    }
}
