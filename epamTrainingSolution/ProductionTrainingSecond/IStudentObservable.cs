using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionTrainingSecond
{
    interface IStudentObservable
    {
        void AddObserver(IStudentObserver o);
        void RemoveObserver(IStudentObserver o);
    }
}
