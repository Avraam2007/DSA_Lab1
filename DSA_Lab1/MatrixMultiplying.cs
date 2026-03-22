using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab1
{
    public class MatrixMultiplyingClass
    {
        private int GetMatrixRows(int[,] matrix)
        {
            return matrix.GetUpperBound(0)+1;
        }

        private int GetMatrixColumns(int[,] matrix)
        {
            return matrix.GetUpperBound(1) + 1;
        }

        public int[,] BasicMultiplying(int[,] x, int[,] y)
        {
            var sw = Stopwatch.StartNew();
            if (x == null || y == null)
            {
                throw new NullReferenceException("Error: one of arguments are null");
            }
            if (GetMatrixColumns(x) != GetMatrixRows(y))
            {
                throw new ArgumentException("Invalid numbers: columns in first matrix should be equal rows in second matrix");
            }

            int m = GetMatrixRows(x);
            int l = GetMatrixRows(y);
            int n = GetMatrixColumns(y);

            int[,] res = new int[m,n];

            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[i,j] = 0;
                    for (int k = 0; k < l; k++)
                    {
                        res[i,j] += x[i,k] * y[k,j];
                    }                    
                }
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");

            return res;
        }
    }
}
