namespace SeventhHomework
{
    using System;

    internal class Circle<T>
    {
        public Circle()
        {
            this.Pointer = new Pointer<T>();
        }

        public Circle(Pointer<T> midPoint, double radius)
        {
            this.Pointer = new Pointer<T>();
            this.Pointer.XPoint = midPoint.XPoint;
            this.Pointer.YPoint = midPoint.YPoint;
            this.Radius = radius;
        }

        public void FindInsection(Circle<T> firstCircle, Circle<T> secondCircle)
        {
            double diagonal = this.FindDistanceBetweenMidPointsOfTwoCircles(firstCircle, secondCircle);
            if (diagonal > (firstCircle.Radius + secondCircle.Radius))
            {
                this.Print("Circles are separate");
            }
            else if (diagonal < Math.Abs(firstCircle.Radius - secondCircle.Radius))
            {
                this.Print("There are no solutions because one circle is contained within the other");
            }
            else if (diagonal == 0 && firstCircle.Radius == secondCircle.Radius)
            {
                this.Print("the circles are coincident and there are an infinite number of solutions");
            }
            else
            {
                double sideOfTriangle = (Math.Pow(firstCircle.Radius, 2) - Math.Pow(secondCircle.Radius, 2) + Math.Pow(diagonal, 2)) / (2 * diagonal);
                double height = Math.Sqrt(Math.Pow(firstCircle.Radius, 2) - Math.Pow(sideOfTriangle, 2));
                Pointer<T> point = new Pointer<T>();
                point.XPoint = (int)(firstCircle.Pointer.XPoint + (sideOfTriangle * (secondCircle.Pointer.XPoint - firstCircle.Pointer.XPoint) / diagonal));
                point.YPoint = (int)(firstCircle.Pointer.YPoint + (sideOfTriangle * (secondCircle.Pointer.YPoint - firstCircle.Pointer.YPoint) / diagonal));
                Pointer<T> firstIntersectionPoint = new Pointer<T>();
                firstIntersectionPoint.XPoint = point.XPoint + (height * (secondCircle.Pointer.YPoint - firstCircle.Pointer.YPoint) / diagonal);
                firstIntersectionPoint.YPoint = point.YPoint + (height * (secondCircle.Pointer.XPoint - firstCircle.Pointer.XPoint) / diagonal);
                Print($"{firstIntersectionPoint.XPoint} && {firstIntersectionPoint.YPoint}");
                Pointer<T> secondIntersectionPoint = new Pointer<T>();
                secondIntersectionPoint.XPoint = point.XPoint - (height * (secondCircle.Pointer.YPoint - firstCircle.Pointer.YPoint) / diagonal);
                secondIntersectionPoint.YPoint = point.YPoint - (height * (secondCircle.Pointer.XPoint - firstCircle.Pointer.XPoint) / diagonal);
                Print($"{secondIntersectionPoint.XPoint} && {secondIntersectionPoint.YPoint}");
            }
        }

        private void Print(string str)
        {
            Console.WriteLine(str);
        }


        private double FindDistanceBetweenMidPointsOfTwoCircles(Circle<T> firstCircle, Circle<T> secondCircle)
        {
            return Math.Sqrt(Math.Pow(firstCircle.Pointer.XPoint - secondCircle.Pointer.XPoint, 2) + Math.Pow(firstCircle.Pointer.YPoint - secondCircle.Pointer.YPoint, 2));
        }

        public Pointer<T> Pointer { get; set; }

        public double Radius { get; set; }

    }
}
