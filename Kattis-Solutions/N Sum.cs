using System;

namespace N_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            string[] sarr = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++) { count += int.Parse(sarr[i]); }
            Console.WriteLine(count);
        }
    }
}
