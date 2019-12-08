using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionTrainingSecond
{
    class Course : IStudentObservable
    {
        private List<IStudentObserver> studentObservers;
        public Course()
        {
            studentObservers = new List<IStudentObserver>();
        }
        public void AddObserver(IStudentObserver o)
        {
            for (int i = 0; i < studentObservers.Count; i++)
            {
                if (studentObservers[i].NumberOfStudent == o.NumberOfStudent)
                {
                    return;
                }
            }
            if(ValidateStudent(o))
                studentObservers.Add(o);
        }

        public void RemoveObserver(IStudentObserver o)
        {
            studentObservers.Remove(o);
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
