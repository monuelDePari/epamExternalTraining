using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond
{
    class FirstTask
    {
        public enum Month { January, February, March, April, May, June, July, August, September, October, November, December }

        public static string GetMonth(int n)
        {
            try
            {
                return Enum.GetName(typeof(Month), n - 1);
            }
            catch (IndexOutOfRangeException)
            {
                return Enum.GetName(typeof(Month), 11);
            }
        }
    }
}
