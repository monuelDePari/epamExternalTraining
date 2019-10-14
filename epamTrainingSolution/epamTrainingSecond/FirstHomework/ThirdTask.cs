using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond
{
    public enum LongRange : Int64 { Max = 9223372036854775807, Min = -9223372036854775808 }
    class epamThirdTask : IPrinter
    {
        public void OutputLongRange()
        {
            foreach (var item in Enum.GetValues(typeof(LongRange)))
            {
                Console.WriteLine(Convert.ToInt64(item));
            }
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
