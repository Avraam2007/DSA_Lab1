using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Lab1
{
    public class EratosthenesSieveClass
    {
        private bool[] sieve(int n)
        {
            var sw = Stopwatch.StartNew();
            bool[] isPrime = new bool[n+1];
            for (int i = 0; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = 2*i; j <= n; j+=i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return isPrime;
        }

        public List<int> getResult(int n)
        {
            if(n<0)
            {
                return null;
            }
            List<int> primeNumbers = new List<int>();
            bool[] isPrime = sieve(n);
            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }
    }
}
