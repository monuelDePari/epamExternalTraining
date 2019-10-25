using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using epamTrainingSecond.SecondTask;
using Microsoft.VisualBasic.Logging;

namespace epamTrainingSecond.SecondHomework
{
    class SecondHomeworkRunner : IRunner
    {
        public void Run()
        {
            ExceptionGenerator exceptionGenerator = new ExceptionGenerator();
            Log log = new Log();
            try
            {
                exceptionGenerator.StackOverflow();
                exceptionGenerator.IndexOutOfRange(new int[4] { 31, 4, 11, 8 }); // Will never happen
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                log.WriteEntry(string.Format("IndexOutOfRangeException"));
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
                log.WriteEntry(string.Format("StackOverflowException"));
            }
            try
            {
                exceptionGenerator.IndexOutOfRange(new int[4] { 31, 4, 11, 8 });
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                log.WriteEntry(string.Format("IndexOutOfRangeException"));
            }
            try
            {
                exceptionGenerator.DoSomeMath(-1, 3);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                log.WriteEntry(string.Format("ArgumentException"));
            }
            Console.ReadKey();
        }
    }
}
