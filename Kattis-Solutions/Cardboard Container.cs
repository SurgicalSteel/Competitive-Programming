using System;
using System.Collections.Generic;

namespace Cardboard_Container
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> factors = new List<int>();
            for(int x = 1; x * x <= n; x++)
            {
                if (n % x == 0) { factors.Add(x); }
            }
            int result = int.MaxValue;
            int t, pl, l, p;
            for(int i=0; i < factors.Count; i++)
            {
                t = factors[i];
                pl = n / t;
                for(int j = 0; j < factors.Count; j++)
                {
                    l = factors[j];
                    if (pl % l != 0) { 
                        continue; 
                    }
                    p = pl / l;
                    result = Math.Min(result, (2 * p * l) + (2 * p * t) + (2 * l * t));
                }
            }
            Console.WriteLine("{0}", result);
        }
    }
}
