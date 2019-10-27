using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework
{
    interface IExceptionGenerator
    {
        void StackOverflow();
        void IndexOutOfRange(int[] GenerateIndexOutOfRangeException);
        void DoSomeMath(int a, int b);
    }
}
