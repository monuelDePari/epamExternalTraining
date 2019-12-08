using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSecondTraining
{
    interface IStudentObserver
    {
        string NameOfStudent { get; set; }
        int NumberOfStudent { get; set; }
        int Age { get; set; }
    }
}
