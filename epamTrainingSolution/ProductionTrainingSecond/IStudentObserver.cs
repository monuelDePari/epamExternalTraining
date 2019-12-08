using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionTrainingSecond
{
    interface IStudentObserver
    {
        public string NameOfStudent { get; set; }
        public int NumberOfStudent { get; set; }
        public int Age { get; set; }
    }
}
