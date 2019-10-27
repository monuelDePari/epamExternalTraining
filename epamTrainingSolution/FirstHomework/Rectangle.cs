using System;

namespace FirstHomework
{
    public struct Rectangle : ISize, ICordinates, IPrinter
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }


        public void Perimeter()
        {
            Print((2 * Width + 2 * Height).ToString());
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
