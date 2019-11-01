﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    interface ICommonLogger : ILogger
    {
        void readMessageLog();
        void writeMessageLog(Exception exception);
    }
}
