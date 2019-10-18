using System;
using System.Diagnostics;
using epamTrainingSecond.FirstHomework;
using epamTrainingSecond.SecondHomework;
using epamTrainingSecond.ThirdHomework;

namespace epamTrainingSecond
{
    class Program
    {
        static void Main(string[] args)
        {
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
            }
            finally
            {
                Console.WriteLine("Somethind went wrong, exit app");
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
