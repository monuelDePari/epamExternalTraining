using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhHomework
{
    class Circle<T>
    {
        void Print(string str)
        {
            Console.WriteLine(str);
        }
        public Circle() 
        {
            pointer = new Pointer<T>();
        }
        public Circle(Pointer<T> midPoint, double radius)
        {
            pointer = new Pointer<T>();
            pointer.XPoint = midPoint.XPoint;
            pointer.YPoint = midPoint.YPoint;
            this.Radius = radius;
        }
        private double FindDistanceBetweenMidPointsOfTwoCircles(Circle<T> firstCircle, Circle<T> secondCircle)
        {
            return Math.Sqrt(Math.Pow(firstCircle.pointer.XPoint - secondCircle.pointer.XPoint, 2) + Math.Pow(firstCircle.pointer.YPoint - secondCircle.pointer.YPoint, 2));
        }
        public void FindInsection(Circle<T> firstCircle, Circle<T> secondCircle)
        {
            double diagonal = FindDistanceBetweenMidPointsOfTwoCircles(firstCircle, secondCircle);
            if (diagonal > (firstCircle.Radius + secondCircle.Radius))
            {
                Print("Circles are separate");
            }else if(diagonal < Math.Abs(firstCircle.Radius - secondCircle.Radius))
            {
                Print("There are no solutions because one circle is contained within the other");
            }else if(diagonal == 0 && firstCircle.Radius == secondCircle.Radius)
            {
                Print("the circles are coincident and there are an infinite number of solutions");
            }else
            {
                double sideOfTriangle = (Math.Pow(firstCircle.Radius, 2) - Math.Pow(secondCircle.Radius, 2) + Math.Pow(diagonal, 2)) / (2 * diagonal);
                double height = Math.Sqrt(Math.Pow(firstCircle.Radius, 2) - Math.Pow(sideOfTriangle, 2));
                Pointer<T> point = new Pointer<T>();
                point.XPoint = (int)(firstCircle.pointer.XPoint + sideOfTriangle * (secondCircle.pointer.XPoint - firstCircle.pointer.XPoint) / diagonal);
                point.YPoint = (int)(firstCircle.pointer.YPoint + sideOfTriangle * (secondCircle.pointer.YPoint - firstCircle.pointer.YPoint) / diagonal);
                Pointer<T> FirstIntersectionPoint = new Pointer<T>();
                FirstIntersectionPoint.XPoint = point.XPoint + height * (secondCircle.pointer.YPoint - firstCircle.pointer.YPoint) / diagonal;
                FirstIntersectionPoint.YPoint = point.YPoint + height * (secondCircle.pointer.XPoint - firstCircle.pointer.XPoint) / diagonal;
                Print($"{FirstIntersectionPoint.XPoint} && {FirstIntersectionPoint.YPoint}");
                Pointer<T> SecondIntersectionPoint = new Pointer<T>();
                SecondIntersectionPoint.XPoint = point.XPoint - height * (secondCircle.pointer.YPoint - firstCircle.pointer.YPoint) / diagonal;
                SecondIntersectionPoint.YPoint = point.YPoint - height * (secondCircle.pointer.XPoint - firstCircle.pointer.XPoint) / diagonal;
                Print($"{SecondIntersectionPoint.XPoint} && {SecondIntersectionPoint.YPoint}");
            }
        }
        public Pointer<T> pointer { get; set; }
        public double Radius { get; set; }

    }
}
