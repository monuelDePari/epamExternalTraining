using System;
using System.Diagnostics;
using epamTrainingSecond.FirstHomework;
using epamTrainingSecond.SecondHomework;

namespace epamTrainingSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstHomeworkRunner firstHomeworkRunner = new FirstHomeworkRunner();
            firstHomeworkRunner.Run();
            SecondHomeworkRunner secondHomeworkRunner = new SecondHomeworkRunner();
            secondHomeworkRunner.Run();
            Console.ReadKey();
        }
    }
}
