using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework
{
    public class SecondTrainingRunner
    {
        public void Run()
        {
            ExceptionGenerator exceptionGenerator = new ExceptionGenerator();
            Logger.FileLogger log = new Logger.FileLogger();
            try
            {
                exceptionGenerator.StackOverflow();
                exceptionGenerator.IndexOutOfRange(new int[4] { 31, 4, 11, 8 }); // Will never happen
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                log.writeMessageLog(e);
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Message);
                log.writeMessageLog(e);
            }
            try
            {
                exceptionGenerator.IndexOutOfRange(new int[4] { 31, 4, 11, 8 });
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                log.writeMessageLog(e);
            }
            try
            {
                exceptionGenerator.DoSomeMath(-1, 3);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                log.writeMessageLog(e);
            }
            Console.ReadKey();
        }
    }
}
