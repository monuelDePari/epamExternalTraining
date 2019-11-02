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
                NinthHomework.Runner runner = new NinthHomework.Runner();
                runner.Run();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                logger.writeMessageLog(e);
            }
            Console.ReadKey();
        }
    }
}
