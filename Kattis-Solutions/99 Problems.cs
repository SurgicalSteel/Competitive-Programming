using System;

namespace _99_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool breaker = false;
            int nu = n, nd = n;
            while (!breaker)
            {
                if (nu % 100 == 99) { Console.WriteLine(nu); breaker = true; }
                else if (nd % 100 == 99) { Console.WriteLine(nd); breaker = true; }
                nu++;
                nd--;
            }
        }
    }
}
