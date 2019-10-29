using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SeventhHomework
{
    public class Runner
    {
        private static System.Timers.Timer aTimer;
        public void Run()
        {
            Pointer<double> point1 = new Pointer<double>();
            point1.XPoint = -1;
            point1.YPoint = 1;
            Circle<double> circle = new Circle<double>(point1, 1);
            Pointer<double> point2 = new Pointer<double>();
            point2.XPoint = 1;
            point2.YPoint = 1;
            Circle<double> circle1 = new Circle<double>(point2, 1);
            Circle<double> circle2 = new Circle<double>();
            circle2.FindInsection(circle, circle1);

            Stopwatch myTimer = new Stopwatch();
            myTimer.Start();
            FileSearcher searcher = new FileSearcher();
            searcher.GetDirectories();
            searcher.FindDuplicates();
            searcher.FindUniqueFiles();
            myTimer.Stop();
            Console.WriteLine($"time taken: {+myTimer.Elapsed}");
            Console.ReadKey();
            Pointer<double> t1 = new Pointer<double>();
            t1.XPoint = 1;
            t1.YPoint = 1;
            Pointer<double> t2 = new Pointer<double>();
            t2.XPoint = 5;
            t2.YPoint = 3;
            Rectangle<double> firstRectangle = new Rectangle<double>(t1, t2);
            firstRectangle.GetSideLength();
            firstRectangle.ChangeSideLength(3, 2);
            firstRectangle.DrawFigure();
        }
    }
}
