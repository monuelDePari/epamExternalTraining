// <copyright file="Rectangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SeventhHomework
{
    using System;

    internal class Rectangle<T>
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public Rectangle(Pointer<double> leftBottomPoint, Pointer<double> rightTopPoint)
        {
            this.LeftBottomPoint = leftBottomPoint;
            this.RightTopPoint = rightTopPoint;
        }

        public void GetSideLength()
        {
            this.FirstSide = Math.Sqrt(Math.Pow(this.RightTopPoint.XPoint - this.LeftBottomPoint.XPoint, 2) + Math.Pow(this.RightTopPoint.YPoint - this.RightTopPoint.YPoint, 2));
            this.SecondSide = Math.Sqrt(Math.Pow(this.RightTopPoint.XPoint - this.RightTopPoint.XPoint, 2) + Math.Pow(this.RightTopPoint.YPoint - this.LeftBottomPoint.YPoint, 2));
            this.Print($"{this.FirstSide}");
            this.Print($"{this.SecondSide}");
        }

        public void ChangeSideLength(double numberToChangeFirstSide, double numberToChangeSecondSide)
        {
            this.FirstSide = numberToChangeFirstSide;
            this.SecondSide = numberToChangeSecondSide;
            this.RightTopPoint.XPoint = this.LeftBottomPoint.XPoint + numberToChangeFirstSide;
            this.RightTopPoint.YPoint = this.LeftBottomPoint.YPoint + numberToChangeSecondSide;
        }

        public void MoveFigure(double numberToMoveFigureByX, double numberToMoveFigureByY)
        {
            this.LeftBottomPoint.XPoint += numberToMoveFigureByX;
            this.LeftBottomPoint.YPoint += numberToMoveFigureByY;
            this.RightTopPoint.XPoint += numberToMoveFigureByX;
            this.RightTopPoint.YPoint += numberToMoveFigureByY;
        }

        public void BuildLessFigure(Rectangle<double> firstRectangleToCompare, Rectangle<double> secondRectangleToCompare)
        {
            if (firstRectangleToCompare.FirstSide * firstRectangleToCompare.SecondSide > secondRectangleToCompare.FirstSide * secondRectangleToCompare.SecondSide)
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
            for (int i = 0; i < this.FirstSide; i++)
            {
                space += " ";
                border += "=";
            }
            for (int i = 0; i < this.LeftBottomPoint.XPoint; i++)
            {
                temp += " ";
            }
            border += "╗" + "\n";
            for (int i = 0; i < this.FirstSide; i++)
            {
                border += temp + "║" + space + "║" + "\n";
            }
            border += temp + "╚";
            for (int i = 0; i < this.FirstSide; i++)
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
                rightTopPoint.XPoint = this.Max(firstRectangle.RightTopPoint.XPoint, secondRectangle.RightTopPoint.XPoint);
                rightTopPoint.YPoint = this.Min(firstRectangle.LeftBottomPoint.YPoint, secondRectangle.LeftBottomPoint.YPoint);
                Pointer<double> leftBottomPoint = new Pointer<double>();
                leftBottomPoint.XPoint = this.Min(firstRectangle.LeftBottomPoint.XPoint, secondRectangle.LeftBottomPoint.XPoint);
                leftBottomPoint.YPoint = this.Max(firstRectangle.LeftBottomPoint.YPoint, secondRectangle.LeftBottomPoint.YPoint);
                return new Rectangle<double>(leftBottomPoint, rightTopPoint);
            }
        }

        private double Min(double a, double b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        private double Max(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public Pointer<double> LeftBottomPoint { get; set; }

        public Pointer<double> RightTopPoint { get; set; }

        public double FirstSide { get; set; }

        public double SecondSide { get; set; }
    }
}
