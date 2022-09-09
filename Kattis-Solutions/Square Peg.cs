using System;

namespace Square_Peg
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(' ');
            double l = double.Parse(sarr[0]);
            double r = double.Parse(sarr[1]);
            double diagonal = Math.Sqrt(Math.Pow(l, 2) + Math.Pow(l, 2));
            double halfdiagonal = diagonal / 2;
            if (halfdiagonal <= r) { Console.WriteLine("fits"); } else { Console.WriteLine("nope"); }
        }
    }
}
