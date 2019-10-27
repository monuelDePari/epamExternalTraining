using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework
{
    class epamFirstTask : IPrinter
    {
        public enum Month { January, February, March, April, May, June, July, August, September, October, November, December }

        public static string GetMonth(int n)
        {
            while (n > 12)
                n /= 12;

            if (n <= 12 && n > 0)
                return Enum.GetName(typeof(Month), n - 1);
            else
                return Enum.GetName(typeof(Month), 11);
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
