using System;

namespace Drinking_Song
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            String thing = Console.ReadLine();

            while (n > 0)
            {
                if (n == 2)
                {
                    Console.WriteLine("2 bottles of {0} on the wall, 2 bottles of {0}.", thing);
                    Console.WriteLine("Take one down, pass it around, 1 bottle of {0} on the wall.", thing);
                    Console.WriteLine();
                }else if (n == 1)
                {
                    Console.WriteLine("1 bottle of {0} on the wall, 1 bottle of {0}.", thing);
                    Console.WriteLine("Take it down, pass it around, no more bottles of {0}.", thing);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("{0} bottles of {1} on the wall, {0} bottles of {1}.", n, thing);
                    Console.WriteLine("Take one down, pass it around, {0} bottles of {1} on the wall.", n - 1, thing);
                    Console.WriteLine();
                }
                n--;
            }
        }
    }
}
