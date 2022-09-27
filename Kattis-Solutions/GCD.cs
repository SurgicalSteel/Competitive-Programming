using System;

namespace GCD
{
    class Program
    {
        static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(' ');
            Console.WriteLine(gcd(int.Parse(sarr[0]), int.Parse(sarr[1])));
        }
    }
}
