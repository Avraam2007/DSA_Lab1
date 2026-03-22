using System;
using System.Diagnostics;

namespace DSA_Lab1
{
    public class FastPowClass
    {
        public double fastPow(double x, double y)
        {
            if (y < 0)
            {
                return fastPow(1 / x, -y);
            }
            else if (y == 0) 
            {
                return 1;
            }
            else if (y%2==0)
            {
                return fastPow(x * x, y / 2);
            }
            else if (y%2==1)
            {
                return x * fastPow(x * x, (y-1) / 2);
            }
            else
            {
                return -1;
            }
        }
    }
}
