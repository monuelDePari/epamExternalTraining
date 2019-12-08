using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEight
{
    public class Runner
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Run()
        {
            string expression = Console.ReadLine();
            CalculatorV2 calculator = new CalculatorV2();
            Console.WriteLine(calculator.Calculate(expression));
            Console.ReadKey();
        }
    }
}
