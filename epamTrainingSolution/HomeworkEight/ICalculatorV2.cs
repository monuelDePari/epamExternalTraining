using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEight
{
    interface ICalculatorV2
    {
        object CalculateExpression(string expression);
        string Input();
    }
}
