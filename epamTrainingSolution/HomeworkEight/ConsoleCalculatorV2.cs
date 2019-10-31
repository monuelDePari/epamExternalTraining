using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEight
{
    class ConsoleCalculatorV2 : ICalculatorV2
    {
        public object Calculate(string expression)
        {
            DataTable data = new DataTable();
            return data.Compute(expression,"");
        }

        public string Input()
        {
            string expression = Console.ReadLine();
            return expression;
        }
    }
}
