using System;

namespace Tower_Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tc = 1;
            string[] lw = Console.ReadLine().Split(" ");
            for(int i = 0; i < n - 1; i++)
            {
                int a = int.Parse(lw[i]);
                int b = int.Parse(lw[i + 1]);
                if (a < b) { tc++; }
            }
            Console.WriteLine("{0}", tc);
        }
    }
}
