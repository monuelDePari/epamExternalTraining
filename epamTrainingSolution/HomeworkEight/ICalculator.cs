using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEight
{
    interface ICalculator
    {
        double CalculatePlus();
        double CalculateMinus();
        double CalculateMultiplication();
        double CalculateDivide();
        void Input();
    }
}
