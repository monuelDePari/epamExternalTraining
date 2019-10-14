using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond.SecondTask
{
    internal class ExceptionGenerator : IExceptionGenerator
    {
        public void DoSomeMath(int a, int b)
        {
            if (a < 0)
                throw new ArgumentException("Parametr should be greater than 0", "a");
            else if (b > 0)
                throw new ArgumentException("Parametr should be less than 0", "b");
        }

        public void IndexOutOfRange(int[] GenerateIndexOutOfRangeException)
        {
            _ = GenerateIndexOutOfRangeException[GenerateIndexOutOfRangeException.Length + 1];
        }

        public void StackOverflow()
        {
            try
            {
                RuntimeHelpers.EnsureSufficientExecutionStack();
                StackOverflow();
            }
            catch (InsufficientExecutionStackException)
            {
                throw new StackOverflowException();
            }
        }
    }
}
