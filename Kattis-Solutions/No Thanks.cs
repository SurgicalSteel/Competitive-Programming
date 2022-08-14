using System;
using System.Collections.Generic;
using System.Linq;

namespace No_Thanks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> raw = new List<int>();
            int tot = 0;
            int n = int.Parse(Console.ReadLine());
            string[] sarr = Console.ReadLine().Split();
            for(int x = 0; x < n; x++) { raw.Add(int.Parse(sarr[x])); }
            raw = raw.OrderBy(x => x).ToList();
            for (int x = 0; x < n; x++)
            {
                if (x == 0) { tot += raw[x]; }
                else if ((raw[x] - raw[x - 1]) > 1) { tot += raw[x]; }
            }
            Console.WriteLine(tot);
        }
    }
}
