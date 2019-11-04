using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NinthHomework
{
    class ThreadSummarizer
    {
        int columns = 0;
        double sumOfNumerics;
        Logger.FileLogger logger = new Logger.FileLogger();
        public double[,] FillNumericsToArray(int n, int m)
        {
            double[,] array = new double[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(1, 1000);
                    //Console.Write($"{array[i, j]} ");
                }
                //Console.WriteLine();
            }
            return array;
        }
        public double[,] IntersectArray(int k, int i, double[,] array)
        {
            int n = 0;
            if (i <= k && i >= 0)
            {
                n = i * array.GetLength(0) / k;
                //m = (i + 1) * array.GetLength(0);
                double[,] newArray = new double[array.GetLength(0) / k, array.GetLength(1)];
                Console.WriteLine(newArray.GetLength(0));
                for (int a = 0; a < newArray.GetLength(0); a++)
                {
                    for (int b = 0; b < array.GetLength(1); b++)
                    {
                        if ((n + a) <= array.GetLength(0))
                        {
                            try
                            {
                                newArray[a, b] = array[n + a, b];
                            }
                            catch(IndexOutOfRangeException e)
                            {
                                logger.writeMessageLog(e);
                            }
                            //newArray[a, b] = array[(n + a), b];
                        }
                        //Console.Write($"{newArray[a, b]} ");
                    }
                    //Console.WriteLine();
                }
                return newArray;
            } else if (i == k)
            {
                columns += array.GetLength(0) % k;
                double[,] newArray = new double[array.GetLength(0) - (k-1)*array.GetLength(0) / k + columns, array.GetLength(1)];
                n = (i - 1) * array.GetLength(0) / k;
                for (int a = 0; a < newArray.GetLength(0); a++)
                {
                    for (int b = 0; b < newArray.GetLength(1); b++)
                    {
                        newArray[a, b] = array[n + a, b];
                    }
                }
                return newArray;
            }
            return null;
        }
        public void StartThreads(int numericOfThreads, int n, int m)
        {
            double[,] arrayToFindSum = FillNumericsToArray(n, m);
            List<Thread> listOfThreads = new List<Thread>(numericOfThreads);
            for (int i = 0; i < numericOfThreads; i++)
            {
                listOfThreads.Add(new Thread(() => FindSumOfTwoDimensionalArray(IntersectArray(numericOfThreads, i, arrayToFindSum))));
                listOfThreads[i].Start();
                Console.WriteLine($"Thread is alive: {listOfThreads[i].IsAlive}");
                //Console.WriteLine($"new thread created {i}");
            }
        }
        public void PrintSum()
        {
            Console.WriteLine(sumOfNumerics);
        }
        public void FindSumOfTwoDimensionalArray(double[,] array)
        {
            foreach (var item in array)
            {
                sumOfNumerics += item;
            }
        }
    }
}
