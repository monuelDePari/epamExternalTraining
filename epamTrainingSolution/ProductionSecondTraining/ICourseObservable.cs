using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSecondTraining
{
    interface ICourseObservable
    {
        void AddObserver(IStudentObserver o, Course course);
        void RemoveObserver(IStudentObserver o);
    }
}
