using System;
using System.Collections.Generic;
using FirstHomework;
using SecondHomework;
using ThirdHomework;
using FifthHomework;
using SixHomework;

namespace epamTrainingSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger logger = new Log.Logger();
            try
            {
                InnerInfoAboutClassesOutputer outputer = new InnerInfoAboutClassesOutputer();
                outputer.Run();
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
