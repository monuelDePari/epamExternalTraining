using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond
{
    public enum LongRange : Int64 { Max = 9223372036854775807, Min = -9223372036854775808 }
    class ThirdTask
    {
        public void OutputLongRange()
        {
            Console.WriteLine($"{LongRange.Min} {LongRange.Max}");
        }
    }
}
