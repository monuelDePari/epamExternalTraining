using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEight
{
    class ConsoleCalculator : ICalculator
    {
        Log.Logger logger = new Log.Logger();
        public void Input()
        {
            try
            {
                firstNumeric = Convert.ToDouble(Console.ReadLine());
                secondNumeric = Convert.ToDouble(Console.ReadLine());
            }catch(FormatException e)
            {
                logger.writeMessageLog(e);
            }catch(Exception e)
            {
                logger.writeMessageLog(e);
            }
        }

        private void Print(string str)
        {
            Console.WriteLine(str);
        }

        public double CalculateDivide()
        {
            return firstNumeric / secondNumeric;
        }

        public double CalculateMinus()
        {
            return firstNumeric - secondNumeric;
        }

        public double CalculateMultiplication()
        {
            return firstNumeric * secondNumeric;
        }

        public double CalculatePlus()
        {
            return firstNumeric + secondNumeric;
        }
        public double firstNumeric { get; set; }
        public double secondNumeric { get; set; }
    }
}
