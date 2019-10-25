﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond.ThirdHomework
{
    class ThirdHomeworkRunner : IRunner
    {
        public void Run()
        {
            DirectorySearcher directorySearcher = new DirectorySearcher();
            directorySearcher.GetSubDirectories(directorySearcher.Path);
            FileByPartialNameFinder fileByPartialNameFinder = new FileByPartialNameFinder();
            fileByPartialNameFinder.GetSubDirectories(fileByPartialNameFinder.Path, "Read");
            fileByPartialNameFinder.Print();
        }
    }
}
