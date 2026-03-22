using System;
using System.Diagnostics;

namespace DSA_Lab1Tests
{
    public class EuclidAlgorytmClass
    {
        public int FindGCD(int x, int y)
        {
            var sw = Stopwatch.StartNew();
            if (x <= 0 || y <= 0)
            {
                return -1;
            }
            while (x != y)
            {
                if (x > y)
                {
                    x -= y;
                }
                else
                {
                    y -= x;
                }
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return x;
        }
    }
}
