using System;
using System.Diagnostics;

namespace DSA_Lab1
{
    public class BinarySearchClass
    {
        public int BinarySearch(int[] arr, int key)
        {
            var sw = Stopwatch.StartNew();
            if (arr != Array.Empty<int>() || arr == null)
            {
                int left = 0;
                int right = arr.Length - 1;
                while (left <= right)
                {
                    int average = left + (right - left) / 2;
                    if (arr[average] == key)
                    {
                        sw.Stop();
                        Console.WriteLine($"Time spent: {sw.Elapsed}");
                        return average;
                    }
                    else if (arr[average] > key)
                    {
                        right = average - 1;
                    }
                    else
                    {
                        left = average + 1;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return -1;
        }
    }
}
