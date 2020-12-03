using System;

namespace Completing_The_Square
{
    class Program
    {
        static double getDist(int ax, int ay, int bx, int by)
        {
            double res;
            double dy = (double)by - (double)ay;
            double dx = (double)bx - (double)ax;
            dy *= dy;
            dx *= dx;
            res = Math.Sqrt(dy + dx);
            return res;
        }
        static void Main(string[] args)
        {
            int ax, ay, bx, by, cx, cy, centerx = 0, centery = 0, sax = 0, say = 0, sbx = 0, sby = 0;
            string[] sarr;
            sarr = Console.ReadLine().Split(" ");
            ax = int.Parse(sarr[0]);
            ay = int.Parse(sarr[1]);
            sarr = Console.ReadLine().Split(" ");
            bx = int.Parse(sarr[0]);
            by = int.Parse(sarr[1]);
            sarr = Console.ReadLine().Split(" ");
            cx = int.Parse(sarr[0]);
            cy = int.Parse(sarr[1]);

            double dab = getDist(ax, ay, bx, by);
            double dcb = getDist(cx, cy, bx, by);
            double dac = getDist(ax, ay, cx, cy);

            if(dab == dcb)
            {
                sax = ax;
                say = ay;
                sbx = cx;
                sby = cy;
                centerx = bx;
                centery = by;
            }
            else if(dab == dac)
            {
                sax = bx;
                say = by;
                sbx = cx;
                sby = cy;
                centerx = ax;
                centery = ay;
            }
            else if(dcb == dac)
            {
                sax = bx;
                say = by;
                sbx = ax;
                sby = ay;
                centerx = cx;
                centery = cy;
            }

            int deltax, deltay;
            deltax = sbx - centerx;
            deltay = sby - centery;

            sax += deltax;
            say += deltay;
            Console.WriteLine("{0} {1}", sax, say);
        }
    }
}
