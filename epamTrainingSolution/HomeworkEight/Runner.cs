﻿using System;
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
<<<<<<< HEAD
            ConsoleCalculator calculator = new ConsoleCalculator();
            calculator.Input();
            Print($"{calculator.CalculateDivide()}");
            Print($"{calculator.CalculateMinus()}");
            Print($"{calculator.CalculateMultiplication()}");
            Print($"{calculator.CalculatePlus()}");
            FileCalculator fileCalculator = new FileCalculator();
            fileCalculator.Input();
            Print($"{fileCalculator.CalculateDivide()}");
            Print($"{fileCalculator.CalculateMinus()}");
            Print($"{fileCalculator.CalculateMultiplication()}");
            Print($"{fileCalculator.CalculatePlus()}");
            Console.ReadKey();
=======
            ConsoleCalculatorV2 consoleCalculator = new ConsoleCalculatorV2();
            Console.WriteLine(consoleCalculator.Calculate(consoleCalculator.Input()));
            //ConsoleCalculator calculator = new ConsoleCalculator();
            //calculator.Input();
            //Print($"{calculator.CalculateDivide()}");
            //Print($"{calculator.CalculateMinus()}");
            //Print($"{calculator.CalculateMultiplication()}");
            //Print($"{calculator.CalculatePlus()}");
            //Console.ReadKey();
            //FileCalculator fileCalculator = new FileCalculator();
            //fileCalculator.Input();
            //Print($"{fileCalculator.CalculateDivide()}");
            //Print($"{fileCalculator.CalculateMinus()}");
            //Print($"{fileCalculator.CalculateMultiplication()}");
            //Print($"{fileCalculator.CalculatePlus()}");
            //Console.ReadKey();
>>>>>>> origin
        }
    }
}
