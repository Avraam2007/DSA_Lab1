using System;
using System.Diagnostics;

namespace DSA_Lab1
{
    public class CountingSortClass
    {
        public int[] CountingSort(int[] arr)
        {
            var sw = Stopwatch.StartNew();
            if (arr == null)
            {
                return null;
            }
            int maxVal = arr[0];

            foreach (int v in arr)
            {
                if(v < 0)
                {
                    return null;
                }
                if (v > maxVal)
                {
                    maxVal = v;
                }
            }

            int[] cntArr = new int[maxVal+1];

            for (int i = 0; i <= maxVal; i++)
            {
                cntArr[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                cntArr[arr[i]]++;
            }

            for (int i = 1; i <= maxVal; i++)
            {
                cntArr[i] += cntArr[i - 1];
            }

            int[] ans = new int[arr.Length];
            for (int i = arr.Length-1; i >= 0; i--)
            {
                int v = arr[i];
                ans[cntArr[v]-1] = v;
                cntArr[v]--;
            }

            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return ans;
        }
    }
}
