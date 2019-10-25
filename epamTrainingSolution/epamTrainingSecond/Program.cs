using System;
using System.Collections.Generic;
using System.Diagnostics;
using epamTrainingSecond.FifthHomework;
using epamTrainingSecond.FirstHomework;
using epamTrainingSecond.SecondHomework;
using epamTrainingSecond.ThirdHomework;
using epamTrainingSecond.SixHomework;
using TestDll1;

namespace epamTrainingSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            try
            {
                InnerInfoAboutClassesOutputer homework = new InnerInfoAboutClassesOutputer();
                homework.Run();
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
