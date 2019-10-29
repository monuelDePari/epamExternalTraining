using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhHomework
{
    class Rectangle<T>
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public Rectangle(Pointer<double> LeftBottomPoint, Pointer<double> RightTopPoint)
        {
            this.LeftBottomPoint = LeftBottomPoint;
            this.RightTopPoint = RightTopPoint;
        }
        public void GetSideLength()
        {
            FirstSide = Math.Sqrt(Math.Pow(RightTopPoint.XPoint - LeftBottomPoint.XPoint, 2) + Math.Pow(RightTopPoint.YPoint - RightTopPoint.YPoint, 2));
            SecondSide = Math.Sqrt(Math.Pow(RightTopPoint.XPoint - RightTopPoint.XPoint, 2) + Math.Pow(RightTopPoint.YPoint - LeftBottomPoint.YPoint, 2));
            Print($"{FirstSide}");
            Print($"{SecondSide}");
        }
        public void ChangeSideLength(double numberToChangeFirstSide, double numberToChangeSecondSide)
        {
            FirstSide = numberToChangeFirstSide;
            SecondSide = numberToChangeSecondSide;
            RightTopPoint.XPoint = LeftBottomPoint.XPoint + numberToChangeFirstSide;
            RightTopPoint.YPoint = LeftBottomPoint.YPoint + numberToChangeSecondSide;
        }
        public void MoveFigure(double numberToMoveFigureByX, double numberToMoveFigureByY)
        {
            LeftBottomPoint.XPoint += numberToMoveFigureByX;
            LeftBottomPoint.YPoint += numberToMoveFigureByY;
            RightTopPoint.XPoint += numberToMoveFigureByX;
            RightTopPoint.YPoint += numberToMoveFigureByY;
        }
        public void BuildLessFigure(Rectangle<double> firstRectangleToCompare, Rectangle<double> secondRectangleToCompare)
        {
            if(firstRectangleToCompare.FirstSide * firstRectangleToCompare.SecondSide > secondRectangleToCompare.FirstSide * secondRectangleToCompare.SecondSide)
            {
                firstRectangleToCompare.DrawFigure();
            }
            else
            {
                secondRectangleToCompare.DrawFigure();
            }
        }
        public void DrawFigure()
        {
            Console.ReadKey();
            Console.Clear();
            string border = "╔", space = "", temp = "";
            for (int i = 0; i < FirstSide; i++)
            {
                space += " ";
                border += "=";
            }
            for (int i = 0; i < LeftBottomPoint.XPoint; i++)
            {
                temp += " ";
            }
            border += "╗" + "\n";
            for (int i = 0; i < FirstSide; i++)
            {
                border += temp + "║" + space + "║" + "\n";
            }
            border += temp + "╚";
            for (int i = 0; i < FirstSide; i++)
            {
                border += "=";
            }
            border += "╝" + "\n";
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 1;
            Console.CursorLeft = 1;
            Console.Write(border);
            Console.ReadKey();
            Console.ResetColor();
        }
        public Rectangle<double> BuildFigureByIntersectionOfTwoFigures(Rectangle<double> firstRectangle, Rectangle<double> secondRectangle)
        {
            if (firstRectangle.LeftBottomPoint.YPoint > secondRectangle.RightTopPoint.YPoint || firstRectangle.RightTopPoint.YPoint < secondRectangle.LeftBottomPoint.YPoint || firstRectangle.RightTopPoint.XPoint > secondRectangle.LeftBottomPoint.XPoint || firstRectangle.LeftBottomPoint.XPoint < secondRectangle.RightTopPoint.XPoint)
            {
                return null;
            }
            else
            {
                Pointer<double> rightTopPoint = new Pointer<double>();
                rightTopPoint.XPoint = Max(firstRectangle.RightTopPoint.XPoint, secondRectangle.RightTopPoint.XPoint);
                rightTopPoint.YPoint = Min(firstRectangle.LeftBottomPoint.YPoint, secondRectangle.LeftBottomPoint.YPoint);
                Pointer<double> leftBottomPoint = new Pointer<double>();
                leftBottomPoint.XPoint = Min(firstRectangle.LeftBottomPoint.XPoint, secondRectangle.LeftBottomPoint.XPoint);
                leftBottomPoint.YPoint = Max(firstRectangle.LeftBottomPoint.YPoint, secondRectangle.LeftBottomPoint.YPoint);
                return new Rectangle<double>(leftBottomPoint, rightTopPoint);
            }
        }
        double Min(double a, double b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        double Max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public Pointer<double> LeftBottomPoint { get; set; }
        public Pointer<double> RightTopPoint { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
    }
}
