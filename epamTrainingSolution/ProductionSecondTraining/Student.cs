using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSecondTraining
{
    class Student : IStudentObserver
    {
        public string NameOfStudent { get; set; }
        public int NumberOfStudent { get; set; }
        public int Age { get; set; }
    }
}
