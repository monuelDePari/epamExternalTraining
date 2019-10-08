using System;

namespace epamTrainingSecond
{
    public struct Rectangle : ISize, ICordinates
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }


        public void Perimetr()
        {
            Console.WriteLine(2 * Width + 2 * Height);
        }
    }
}
