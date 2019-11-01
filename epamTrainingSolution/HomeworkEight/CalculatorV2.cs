using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEight
{
    class CalculatorV2 : ICalculatorV2
    {
        public object CalculateExpression(string expression)
        {
            DataTable dataTable = new DataTable();
            var resultOfExpression = dataTable.Compute(expression, "");
            return resultOfExpression;
        }

        public string Input()
        {
            string expression = Console.ReadLine();
            return expression;
        }
    }
}
