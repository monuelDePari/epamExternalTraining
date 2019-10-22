using System;
using System.Collections.Generic;
using System.Diagnostics;
using epamTrainingSecond.FifthHomework;
using epamTrainingSecond.FirstHomework;
using epamTrainingSecond.SecondHomework;
using epamTrainingSecond.ThirdHomework;

namespace epamTrainingSecond
{
    class Program
    {
        //private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            try
            {
                FirstHomeworkRunner firstHomeworkRunner = new FirstHomeworkRunner();
                firstHomeworkRunner.Run();
                SecondHomeworkRunner secondHomeworkRunner = new SecondHomeworkRunner();
                secondHomeworkRunner.Run();
                ThirdHomeworkRunner thirdHomeworkRunner = new ThirdHomeworkRunner();
                thirdHomeworkRunner.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                logger.writeMessageLog(e);
            }
            Console.ReadKey();
        }
    }
}
