using System;
using System.Collections.Generic;
using System.Linq;

namespace Minimal_Fibonacci_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[45];
            fib[0] = 1;
            fib[1] = 1;
            for(int i = 2; i < 45; i++) { fib[i] = fib[i - 1] + fib[i - 2]; }
            //for(int i = 0; i < 45; i++) { Console.WriteLine(fib[i]); }
            
            int n = int.Parse(Console.ReadLine());
            int curr = 0;
            int temp;
            List<int> l = new List<int>();
            while (curr < n)
            {
                temp = getposs(fib, n - curr);
                l.Add(temp);
                curr += temp;
            }
            l.Sort();
            string s = "";
            for(int i = 0; i < l.Count; i++) { if (i == 0) { s += l[i].ToString(); } else { s += (" " + l[i].ToString()); } }
            Console.WriteLine(s);
            
        }

        static int getposs(int[] fib, int rem)
        {
            for(int i = 44; i >= 0; i--)
            {
                if (fib[i] <= rem) { return fib[i]; }
            }
            return 0;
        }
    }
}
