using System;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(' ');
            double h = double.Parse(sarr[0]);
            double b = double.Parse(sarr[1]);
            double res = h * b / 2;
            Console.WriteLine("{0:F7}", res);
        }
    }
}
