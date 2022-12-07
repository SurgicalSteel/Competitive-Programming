using System;

namespace Disc_District
{
    class Program
    {
        static void Main(string[] args)
        {
            long r = long.Parse(Console.ReadLine());
            long rsq = r * r;
            bool breaker = false;
            for(long x = 1; x <= r; x++) 
            {
                if (breaker) { break; }
                for(long y = 1; y <=r; y++)
                {
                    if ((x*x) + (y*y) >= rsq)
                    {
                        Console.WriteLine("{0} {1}", x, y);
                        breaker = true;
                        break;
                    }
                }
            }
        }
    }
}
