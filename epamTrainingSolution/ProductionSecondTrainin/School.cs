using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSecondTrainin
{
    public class School : ICourseObservable
    {
        List<Course> coursesList;
        List<IStudentObserver> studentList;
        public School()
        {
            coursesList = new List<Course>();
            studentList = new List<IStudentObserver>();
        }
        public List<IStudentObserver> GetListOfStudents()
        {
            foreach (var student in studentList)
            {
                Console.WriteLine($"Name: {student.NameOfStudent} Age: {student.Age} Number: {student.NumberOfStudent}");
            }
            return studentList;
        }
        public void AddObserver(IStudentObserver student, Course course)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].NumberOfStudent == student.NumberOfStudent)
                {
                    return;
                }
            }
            if (ValidateStudent(student))
            {
                studentList.Add(student);
                course.AddObserver(student);
            }
        }
        public void RemoveObserver(IStudentObserver student)
        {
            for (int i = 0; i < coursesList.Count; i++)
            {
                coursesList[i].RemoveObserver(student);
            }
            studentList.Remove(student);
        }
        private bool ValidateStudent(IStudentObserver o)
        {
            if (o.NameOfStudent != null && o.Age < 30 && (o.NumberOfStudent >= 10000 && o.NumberOfStudent <= 99999))
                return true;
            else
                return false;
        }
    }
}
