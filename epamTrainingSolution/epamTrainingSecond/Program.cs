using System;
using System.Collections.Generic;
using FirstHomework;
using SecondHomework;
using ThirdHomework;
using FifthHomework;
using SixHomework;
using Logger;
using System.Threading;
using ProductionSecondTrainin;

namespace epamTrainingSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger logger = new FileLogger();
            try
            {
                Runner runner = new Runner();
                runner.Run();
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
