using System;

namespace Divvying_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] sarr = Console.ReadLine().Split(' ');
            int tot = 0;
            for(int i = 0; i < n; i++) { tot += int.Parse(sarr[i]); }
            Console.WriteLine(tot % 3 == 0 ? "yes" : "no");
        }
    }
}

