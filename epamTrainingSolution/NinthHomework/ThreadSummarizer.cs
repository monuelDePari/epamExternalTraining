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
        double[,] arrayOfNumeric = new double[1000, 1000];
        double sumOfNumerics = 0;
        public double[,] FillNumericsToArray(int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrayOfNumeric[i, j] = new Random().Next(1, 1000);
                }
            }
            return arrayOfNumeric;
        }
        private double[,] IntersectArray(int k, int i, double[,] array)
        {
            int n = 0;
            if (i != k)
            {
                n = i * array.GetLength(0) / k;
                //m = (i + 1) * array.GetLength(0);
                double[,] newArray = new double[(int)array.GetLength(0) / k, array.GetLength(1)];
                for (int a = 0; a < newArray.GetLength(0); a++)
                {
                    for (int b = 0; b < newArray.GetLength(1); b++)
                    {
                        newArray[a, b] = array[n + a, b];
                    }
                }
                return newArray;
            } else if (i == k)
            {
                double[,] newArray = new double[(int)(k - 1) * array.GetLength(0) / k, array.GetLength(1)];
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
        public void StartThreads(int numericOfThreads)
        {
            List<Thread> listOfThreads = new List<Thread>(numericOfThreads);
            for (int i = 0; i < listOfThreads.Count; i++)
            {
                listOfThreads[i] = new Thread(() => FindSumOfTwoDimensionalArray(IntersectArray(numericOfThreads, i, FillNumericsToArray(1000, 1000))));
                listOfThreads[i].Start();
            }
        }
        public void PrintSum()
        {
            Console.WriteLine(sumOfNumerics);
        }
        private double FindSumOfTwoDimensionalArray(double[,] array)
        {
            double sum = 0;
            foreach (double item in array)
            {
                sum += item;
            }
            sumOfNumerics += sum;
            return sum;
        }
    }
}
