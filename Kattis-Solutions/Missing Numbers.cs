using System;
using System.Collections.Generic;
using System.Linq;

namespace Missing_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> l = new List<int>();
            List<int> should = new List<int>();
            List<int> miss = new List<int>();
            int t,max = 0;
            for(int i = 0; i < n; i++)
            {
                t = int.Parse(Console.ReadLine());
                l.Add(t);
                max = Math.Max(max, t);
            }
            for(int i = 1; i <= max; i++)
            {
                should.Add(i);
            }
            for(int i = 0; i < should.Count; i++)
            {
                bool has = l.Any(num =>(num == should[i]));
                if (!has)
                {
                    miss.Add(should[i]);
                }
            }
            if (miss.Count == 0)
            {
                Console.WriteLine("good job");
            }
            else
            {
                for(int i = 0; i < miss.Count; i++)
                {
                    Console.WriteLine(miss[i]);
                }
            }
        }
    }
}
