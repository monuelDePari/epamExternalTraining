﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond
{
    interface ILogger
    {
        void readMessageLog();
        void writeMessageLog(Exception exception);
    }
}