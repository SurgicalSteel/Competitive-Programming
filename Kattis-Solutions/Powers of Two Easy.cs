using System;

namespace Powers_of_2_Easy
{
    class Program
    {
        static string getpoweroftwo(int n)
        {
            return ((int) Math.Pow(2, n)).ToString();
        }

        static void Main(string[] args)
        {
            int n, e;
            string[] sarr = Console.ReadLine().Split(' ');
            n = int.Parse(sarr[0]);
            e = int.Parse(sarr[1]);
            string pot = getpoweroftwo(e);
            string bs = "";
            int nc = 0;
            for(int i = 0; i <= n; i++)
            {
                bs= i.ToString();
                if (bs.Contains(pot)) { nc++; }
            }
            Console.WriteLine(nc);
        }
    }
}

