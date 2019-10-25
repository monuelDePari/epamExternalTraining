using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond.FirstHomework
{
    class FirstHomeworkRunner : IRunner
    {
        public void Run()
        {
            ConsolePrinter consolePrinter = new ConsolePrinter();
            Person person = new Person();
            person.Name = "Andrew";
            person.Surname = "Troelsen";
            person.Age = 31;
            person.Print(person.CheckIfElder(person.Age));
            Rectangle rectangle = new Rectangle();
            rectangle.X = 5;
            rectangle.Y = -3;
            rectangle.Width = 45;
            rectangle.Height = 51;
            rectangle.Perimeter();
            epamFirstTask epamFirstTask = new epamFirstTask();
            consolePrinter.Print("Please write positive integer");
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());
            epamFirstTask.Print(epamFirstTask.GetMonth(numberOfMonth));
            epamSecondTask epamSecondTask = new epamSecondTask();
            epamSecondTask.OutputUnsortedEnum();
            epamSecondTask.RandomColorGenerator();
            epamSecondTask.SortColors();
            epamSecondTask.OutputSortedColors();
            epamThirdTask epamThirdTask = new epamThirdTask();
            epamThirdTask.OutputLongRange();
            Console.ReadKey();
        }
    }
}
