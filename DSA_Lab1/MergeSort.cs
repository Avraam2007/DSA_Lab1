using System;
using System.Diagnostics;

namespace DSA_Lab1
{
    public class MergeSortClass
    {
        private double[] Merge(double[] arr, int left, int mid, int right) {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            double[] L = new double[n1];
            double[] R = new double[n2];

            for (int i1 = 0; i1 < n1; i1++) {
                L[i1] = arr[left + i1];
            }
            for (int j1 = 0; j1 < n2; j1++) {
                R[j1] = arr[mid + 1 + j1];
            }

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2) {
                if (L[i] <= R[j]) {
                    arr[k] = L[i];
                    i++;
                }
                else {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1) {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2) {
                arr[k] = R[j];
                j++;
                k++;
            }
            return arr;
        }

        private double[] MergeSort(double[] arr, int left, int right)
        {
            if (left<right && arr != Array.Empty<double>())
            {
                int mid = (left+right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
            return arr;
        }

        public double[] MergeSort(double[] array) {
            var sw = Stopwatch.StartNew();
            double[] sortedArray = MergeSort(array, 0, array.Length - 1);
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return sortedArray;
        }
    }
}
