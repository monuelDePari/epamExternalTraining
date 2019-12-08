using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSecondTrainin
{
    public interface ICourseObservable
    {
        void AddObserver(IStudentObserver o, Course course);
        void RemoveObserver(IStudentObserver o);
    }
}
