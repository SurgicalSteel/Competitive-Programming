using System;

namespace Vedur_Lokadar_Heidar
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentWind = int.Parse(Console.ReadLine());
            int nc = int.Parse(Console.ReadLine());
            string[] sarr;
            for(int i = 0; i < nc; i++)
            {
                sarr = Console.ReadLine().Split(' ');
                if (int.Parse(sarr[1]) < currentWind)
                {
                    Console.WriteLine(sarr[0] + " " + "lokud");
                }
                else
                {
                    Console.WriteLine(sarr[0] + " " + "opin");
                }
            }
        }
    }
}
