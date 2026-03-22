using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;

namespace DSA_Lab1
{
    public class SubstringSearch
    {
        public int SimpleSearch(string search, string sub) 
        {
            var sw = Stopwatch.StartNew();
            for (int i = 0; i <= search.Length - sub.Length; i++)
            {
                for (int j = 0; j < sub.Length; j++)
                {
                    if(search[i+j] == sub[j])
                    {
                        break;
                    }
                }
                return i;
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return -1; 
        }

        public List<int> ZSearch(string s)
        {
            var sw = Stopwatch.StartNew();
            int n = s.Length;
            List<int> z = new List<int>(n);
            for (int i = 0; i < z.Count; i++)
            {
                z[i] = 0;
            }
            int left = 0, right = 0;
            for (int i = 1; i < n; i++)
            {
                if(i<=right)
                {
                    int a = right - i + 1;
                    z[i] = a < z[i - left] ? a : z[i - left];
                }
                while (i + z[i] < n && s[z[i]] == s[i + z[i]])
                {
                    z[i]++;
                    if (i + z[i] - 1 >  right)
                    {
                        right = i + z[i]-1;
                        left = i;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine($"Time spent: {sw.Elapsed}");
            return z;
        }
    }
}
