using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab1
{
    internal class Program
    {
        static int[] randomArr(int n) {
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next()%1000;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            CountingSortClass sel = new CountingSortClass();
            int[] array = randomArr(1000);
            sel.CountingSort(array);
        } 
    }
}
