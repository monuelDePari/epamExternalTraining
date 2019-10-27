using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework
{
    public enum Color : int { Red = 4, Blue = 15, Green = 1, White = 7, Purple = 3, Magenta = 6, Grey = 11 }

    class epamSecondTask : IPrinter, IEnumGetter
    {
        static Dictionary<string, int> color = new Dictionary<string, int>();

        public void OutputUnsortedEnum()
        {
            var ColorValues = GetValues<Color>();
            foreach (var item in ColorValues)
            {
                Print(item.ToString());
            }
        }

        public void SortColors()
        {
            color = color.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public void RandomColorGenerator()
        {
            Random random = new Random();
            foreach (Color item in Enum.GetValues(typeof(Color)))
            {
                color.Add(item.ToString(), (int)item);
                color[item.ToString()] = random.Next(1, 100);
            }
        }

        public void OutputSortedColors()
        {
            foreach (var item in color)
            {
                Print($"{item.Key} = {item.Value}");
            }
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
