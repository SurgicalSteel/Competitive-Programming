using System;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, b2, c3;
            string[] sarr;
            sarr = Console.ReadLine().Split(' ');
            int s, e;
            a1 = int.Parse(sarr[0]);
            b2 = int.Parse(sarr[1]);
            c3 = int.Parse(sarr[2]);

            int[] x = new int[101];
            int[] y = new int[101];
            int[] z = new int[101];

            for (int i = 0; i < 101; i++)
            {
                x[i] = 0;
                y[i] = 0;
                z[i] = 0;
            }

            sarr = Console.ReadLine().Split(' ');
            s = int.Parse(sarr[0]);
            e = int.Parse(sarr[1]);
            for (int i = s; i < e; i++)
            {
                x[i] += 1;
            }

            sarr = Console.ReadLine().Split(' ');
            s = int.Parse(sarr[0]);
            e = int.Parse(sarr[1]);
            for (int i = s; i < e; i++)
            {
                y[i] += 1;
            }

            sarr = Console.ReadLine().Split(' ');
            s = int.Parse(sarr[0]);
            e = int.Parse(sarr[1]);
            for (int i = s; i < e; i++)
            {
                z[i] += 1;
            }

            int tc, res=0;
            for (int i = 0; i < 101; i++)
            {
                tc = x[i] + y[i] + z[i];
                if (tc == 1) { res += (a1 * tc); }
                else if (tc == 2) { res += (b2 * tc); }
                else if (tc == 3) { res += (c3 * tc); }
            }
            Console.WriteLine(res);
        }
    }
}
