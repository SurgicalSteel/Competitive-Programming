using System;

namespace Darts
{
    class Program
    {
        static double[] rad = new double[] { 20, 40, 60, 80, 100, 120, 140, 160, 180, 200 };

        static double calcdist(int x, int y) 
        {
            return Math.Sqrt(x * x + y * y);
        }

        static int getscore(int x, int y)
        {
            int score = 0;
            double dist = calcdist(x, y);
            for(int i = 9; i >= 0; i--)
            {
                if (dist > rad[i]) { break; } else
                {
                    score++;
                }
            }

            return score;
        }

        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            int sz, tot, tx, ty;
            string[] sarr;
            for(int x = 0; x < tc; x++)
            {
                tot = 0;
                sz = int.Parse(Console.ReadLine());
                for(int i = 0; i < sz; i++) 
                {
                    sarr = Console.ReadLine().Split(' ');
                    tx = int.Parse(sarr[0]);
                    ty = int.Parse(sarr[1]);
                    tot += getscore(tx, ty);
                }
                Console.WriteLine(tot);
            }

        }
    }
}

