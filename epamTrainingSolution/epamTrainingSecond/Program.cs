using System;
using System.Collections.Generic;
using FirstHomework;
using SecondHomework;
using ThirdHomework;
using FifthHomework;
using SixHomework;
using Logger;

namespace epamTrainingSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            //SeventhHomework.Runner runner = new SeventhHomework.Runner();
            //runner.Run();
            FileLogger logger = new FileLogger();
            try
            {
                FifthHomework.FifthHomeworkRunner runner = new FifthHomework.FifthHomeworkRunner();
                runner.Run();
            }catch(Exception e)
            {
                logger.writeMessageLog(e);
            }
            Console.ReadKey();
        }
    }
}
