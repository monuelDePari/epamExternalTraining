using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond
{
    class ConsolePrinter : IPrinter
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
