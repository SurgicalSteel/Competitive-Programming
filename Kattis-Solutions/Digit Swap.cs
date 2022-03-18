using System;

namespace Digit_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int p, s;
            s = x % 10;
            p = (x - s) / 10;
            Console.WriteLine((s * 10) + p);
        }
    }
}

