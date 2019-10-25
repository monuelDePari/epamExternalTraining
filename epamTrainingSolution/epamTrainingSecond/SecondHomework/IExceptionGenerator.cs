using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond.SecondTask
{
    interface IExceptionGenerator
    {
        void StackOverflow();
        void IndexOutOfRange(int[] GenerateIndexOutOfRangeException);
        void DoSomeMath(int a, int b);
    }
}
