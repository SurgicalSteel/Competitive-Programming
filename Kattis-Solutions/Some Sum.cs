using System;

namespace Some_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Either");
            }
            else
            {
                // 50 51 52
                // 51 52 53
                int sumA = 0, sumB = 0;
                for (int i = 50; i < 50 + n; i++)
                {
                    sumA += i;
                }
                for (int i = 51; i <= 50 + n; i++)
                {
                    sumB += i;
                }
                if (sumA % 2 == 0 && sumB % 2 == 0)
                {
                    Console.WriteLine("Even");
                }else if (sumA % 2 != 0 && sumB % 2 != 0)
                {
                    Console.WriteLine("Odd");
                }
                else
                {
                    Console.WriteLine("Either");
                }
            }
        }
    }
}
