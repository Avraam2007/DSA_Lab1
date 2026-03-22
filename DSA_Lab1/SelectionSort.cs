using System;
using System.Diagnostics;

namespace DSA_Lab1
{
    public class SelectionSortClass
    {
        public double[] SelectionSort(double[]arr)
        {
            var sw = Stopwatch.StartNew();
            if (arr == null)
            {
                return null;
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if(min != i)
                {
                    double tmp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = tmp;
                }
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return arr;
        }
    }
}
