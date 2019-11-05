using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinthHomework
{
    public class Runner
    {
        public void Run()
        {
            ThreadSummarizer summarizer = new ThreadSummarizer();
            summarizer.FindSum(1000, 1000, 4);
            summarizer.PrintSum();
        }
    }
}
