using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond
{
    public enum Color : int { Red = 4, Blue = 15, Green = 1, White = 7, Purple = 3, Magenta = 6, Grey = 11 }

    class SecondTask
    {
        static Dictionary<string, int> color = new Dictionary<string, int>();

        public static void SortColors()
        {
            color = color.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public static void RandomColorGenerator()
        {
            Random random = new Random();
            foreach (Color item in Enum.GetValues(typeof(Color)))
            {
                color.Add(item.ToString(), (int)item);
                color[item.ToString()] = random.Next(1, 100);
            }
        }

        public static void OutputSortedColors()
        {
            foreach (var item in color)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}
