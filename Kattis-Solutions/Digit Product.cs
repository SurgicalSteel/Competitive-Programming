using System;

namespace Digit_Product
{
    class Program
    {
        static int getProductDigit(int x)
        {
            if (x <= 0) { return 0; }
            int prod = 1, tmpmod = 0;
            while (x > 0)
            {
                tmpmod = x % 10;
                if (tmpmod > 0) { prod *= tmpmod; }
                x -= tmpmod;
                x /= 10;
            }
            return prod;
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            while (x >= 10) {
                x = getProductDigit(x);
                if (x < 10) { break; }
            }
            Console.WriteLine(x);
        }
    }
}
