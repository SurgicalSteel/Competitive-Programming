using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {arr[i] = int.Parse(Console.ReadLine());}

            if (n % 2 > 0) { Console.WriteLine("still running"); return; }

            long tot = 0;
            for(int i = 0; i < n-1; i+=2)
            {tot += (long)Math.Abs(arr[i] - arr[i + 1]);}

            Console.WriteLine("{0}", tot);
        }
    }
}
