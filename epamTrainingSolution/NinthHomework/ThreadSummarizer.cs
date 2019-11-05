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
        double[,] a;
        public int k = 0, c;
        public double result = 0;
        public byte x = 0, y = 1;

        public double[,] FillNumericsToArray(int n, int m)
        {
            a = new double[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = random.Next(1, 100);
                }
            }
            return a;
        }

        public double ThreadItem(int i)
        {
            double res = 0;
            int r = i * c + c;
            if (i == k - 1) { r = a.GetLength(x); }
            for (int j = i * c; j < r; j++)
            {
                for (int e = 0; e < a.GetLength(y); e++)
                {
                    if (y == 0) { res += a[e, j]; }
                    else { res += a[j, e]; }
                }
            }
            result += res;
            return res;
        }

        public void FindSum(int n, int m, int k)
        {
            if (a == null)
                FillNumericsToArray(n, m);

            if (a.GetLength(1) > a.GetLength(0))
            {
                x = 1;
                y = 0;
            }

            if (k < 1) { k = 1; }
            else if (k > a.GetLength(x)) { k = a.GetLength(x); }
            this.k = k;

            c = (int)Math.Round((double)a.GetLength(x) / k);

            for (int i = 0; i < k; i++)
            {
                int ii = i;
                ThreadStart ts = new ThreadStart(() => ThreadItem(ii));
                Thread t = new Thread(ts);
                t.Start();
                t.Join();
            }
        }

        public void PrintSum()
        {
            Console.WriteLine($"Sum of array: {result}");
        }
    }
}
