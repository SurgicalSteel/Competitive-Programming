using System;

namespace Decimal_Deletion
{
    class Program
    {
        static void Main(string[] args)
        {
            double di = double.Parse(Console.ReadLine());
            double res = Math.Round(di);
            Console.WriteLine(res);
        }
    }
}
