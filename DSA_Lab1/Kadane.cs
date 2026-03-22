using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab1
{
    public class KadaneClass
    {
        public int Kadane(int[] n)
        {
            var sw = Stopwatch.StartNew();
            int sum = 0, max = 0;
            foreach (int item in n)
            {
                sum += item;
                if (sum > max) max = sum;
                if (sum < 0) sum = 0;
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return max;
        }
    }
}
