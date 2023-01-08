using System;
using System.Collections.Generic;
using System.Linq;
namespace Trip_Odometer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t, tot = 0;
            string[] sarr;
            n = int.Parse(Console.ReadLine());
            sarr = Console.ReadLine().Split(' ');
            Dictionary<int, bool> d = new Dictionary<int, bool>();
            for (int i = 0; i < n; i++)
            {
                t = int.Parse(sarr[i]);
                tot += t;
                if (!d.ContainsKey(t)) { d.Add(t, true); }
            }
            List<int> tl = new List<int>();
            foreach (int x in d.Keys) { tl.Add(tot - x); }
            tl.Sort();
            Console.WriteLine(tl.Count);
            for (int i = 0; i < tl.Count; i++)
            {
                if (i == 0) { Console.Write(tl[i]); }
                else { Console.Write(" " + tl[i]); }
            }
            Console.WriteLine();
        }
    }
}
