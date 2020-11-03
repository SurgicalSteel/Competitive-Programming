using System;
using System.Collections.Generic;

namespace Electrical_Outlets
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            string[] sarr;
            int no, tmpCount;
            List<int> ls;
            for (int i = 0; i < tc; i++)
            {
                sarr = Console.ReadLine().Split(" ");
                no = int.Parse(sarr[0]);
                ls = new List<int>();
                for (int x = 1; x < sarr.Length; x++) { ls.Add(int.Parse(sarr[x])); }
                ls.Sort();
                tmpCount = 0;
                for (int x = 0; x < ls.Count; x++)
                {
                    if (x + 1 == ls.Count) { tmpCount += ls[x]; }
                    else { tmpCount += (ls[x] - 1); }
                }
                Console.WriteLine("{0}", tmpCount);
            }
        }
    }
}
