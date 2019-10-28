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
        public Pointer<double> LeftBottomPoint { get; set; }
        public Pointer<double> RightTopPoint { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
    }
}
