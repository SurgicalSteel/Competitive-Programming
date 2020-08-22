using System;

namespace Soda_Slurper
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, p,tot,n=0,tmp;
            string[] arr = Console.ReadLine().Split(" ");
            a = int.Parse(arr[0]);
            b = int.Parse(arr[1]);
            p = int.Parse(arr[2]);

            tot = a + b;

            while (tot >= p)
            {
                tmp = (tot / p) + (tot % p);
                n += tot / p;
                tot = tmp;
            }
            Console.WriteLine(n);
        }
    }
}
