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
            FileLogger logger = new FileLogger();
            try
            {
                FirstHomework.FirstTrainingRunner firstTraining = new FirstTrainingRunner();
                firstTraining.Run();
                SecondHomework.SecondTrainingRunner trainingRunner = new SecondTrainingRunner();
                trainingRunner.Run();
                HomeworkEight.Runner runner = new HomeworkEight.Runner();
                runner.Run();
            }catch(Exception e)
            {
                logger.writeMessageLog(e);
            }
            Console.ReadKey();
        }
    }
}
