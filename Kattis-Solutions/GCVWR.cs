using System;

namespace GCVWR
{
    class Program
    {
        static void Main(string[] args)
        {
            int g, t, n;
            string[] sarr;
            sarr = Console.ReadLine().Split(' ');
            g = int.Parse(sarr[0]);
            t = int.Parse(sarr[1]);
            sarr = Console.ReadLine().Split(' ');
            int tot = 0;
            for(int i = 0; i < sarr.Length; i++) { tot += int.Parse(sarr[i]); }
            int maxi = (90 * (g - t) / 100) - tot;
            Console.WriteLine(maxi);
        }
    }
}
