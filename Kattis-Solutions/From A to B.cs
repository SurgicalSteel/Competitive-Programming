using System;

namespace From_A_to_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(' ');
            int a = int.Parse(sarr[0]);
            int b = int.Parse(sarr[1]);
            int res = 0;
            bool breaker = false;
            if (a <= b) { res = b - a; } 
            else
            {
                while (!breaker)
                {
                    if (a > b && a % 2 == 0) { a = a / 2; res++; } else
                    if (a > b && a % 2 == 1) { a = (a +1)/ 2; res += 2; }
                    else if (a < b) { res += (b - a); a = b; }
                    
                    if (a == b) { breaker = true; }
                }
            }
            Console.WriteLine(res);
        }
    }
}
