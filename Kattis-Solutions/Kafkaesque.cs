using System;

namespace Kafkaesque
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int passCount = 1;
            int last = 0, t;
            for(int i = 0; i < n; i++)
            {
                t = int.Parse(Console.ReadLine());
                if (i > 0)
                {
                    if (t< last)
                    {
                        passCount++;
                    }
                }
                last = t;
            }
            Console.WriteLine(passCount);
        }
    }
}
