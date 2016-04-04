using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitting_The_Targets
{
    class Program
    {
        struct rectangle
        {
            public rectangle(int xax, int yay, int xbx, int yby)
            {
                this.xa = xax;
                this.ya = yay;
                this.xb = xbx;
                this.yb = yby;
            }
            public int xa, ya, xb, yb;
        }
        struct circle
        {
            public circle(int xc,int yc, int rad)
            {
                this.x = xc;
                this.y = yc;
                this.r = rad;
            }
            public int x, y, r;
        }
        static bool insidecircle(circle a, int x, int y)
        {
            return (((x - a.x) * (x - a.x)) + ((y - a.y) * (y - a.y))) <= a.r * a.r;
        }
        static bool insiderectangle(rectangle a, int x, int y)
        {
            return x >= a.xa && x <= a.xb && y >= a.ya && y <= a.yb;
        }
        static void Main(string[] args)
        {
            int nob = int.Parse(Console.ReadLine());
            List<rectangle> cor = new List<rectangle>();
            List<circle> coc = new List<circle>();
            string[] temps;
            for (int x=0;x< nob; ++x)
            {
                temps = Console.ReadLine().Split();
                if (temps[0].Equals("rectangle"))
                {cor.Add(new rectangle(int.Parse(temps[1]), int.Parse(temps[2]), int.Parse(temps[3]), int.Parse(temps[4])));}
                else { coc.Add(new circle(int.Parse(temps[1]), int.Parse(temps[2]), int.Parse(temps[3]))); }
            }
            int nop = int.Parse(Console.ReadLine());
            for(int x=0;x< nop; ++x)
            {
                temps = Console.ReadLine().Split();
                int ctr = 0;
                int xt = int.Parse(temps[0]), yt = int.Parse(temps[1]);
                for(int i = 0; i < cor.Count; ++i)
                {
                    if (insiderectangle(cor[i], xt, yt)) { ctr++; }
                }
                for (int i = 0; i < coc.Count; ++i)
                {
                    if (insidecircle(coc[i], xt, yt)) { ctr++; }
                }
                Console.WriteLine(ctr);
            }
            Console.ReadLine();
        }
    }
}
