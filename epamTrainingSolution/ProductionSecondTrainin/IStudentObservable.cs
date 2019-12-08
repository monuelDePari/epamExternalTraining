﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSecondTrainin
{
    public interface IStudentObservable
    {
        void AddObserver(IStudentObserver o);
        void RemoveObserver(IStudentObserver o);
    }
}
