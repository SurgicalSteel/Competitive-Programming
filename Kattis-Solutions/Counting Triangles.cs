using System;
using System.Collections.Generic;
namespace Counting_Triangles
{
    class Program
    {
        struct Point
        {
            public float x;
            public float y;
            public Point(float x, float y) { this.x = x; this.y = y; }
        }

        struct Segment
        {
            public Point start;
            public Point end;
            public Segment(Point s, Point e) { this.start = s; this.end = e; }
        }

        static bool ccw(Point A, Point B, Point C) { return (C.y - A.y) * (B.x - A.x) > (B.y - A.y) * (C.x - A.x); }
        static bool intersect (Point As, Point Ae, Point Bs, Point Be) 
        {
            return ccw(As, Bs, Be) != ccw(Ae, Bs, Be) && ccw(As, Ae, Bs) != ccw(As, Ae, Be);
        }
        static void Main(string[] args)
        {
            int n;
            string[] sarr;
            float sx,sy,ex,ey;
            n = int.Parse(Console.ReadLine());
            List<Segment> ls;
            Segment ti, tj, tk;
            int counter;
            while (n > 0)
            {
                counter = 0;
                ls = new List<Segment>();
                for(int i = 0; i < n; i++) 
                {
                    sarr = Console.ReadLine().Split();
                    sx = float.Parse(sarr[0]);
                    sy = float.Parse(sarr[1]);
                    ex = float.Parse(sarr[2]);
                    ey = float.Parse(sarr[3]);
                    ls.Add(new Segment(new Point(sx, sy), new Point(ex, ey)));
                }

                for(int i = 0; i < ls.Count - 1; i++)
                {
                    for(int j = i + 1; j < ls.Count; j++)
                    {
                        ti = ls[i];
                        tj = ls[j];
                        if(intersect(ti.start, ti.end, tj.start, tj.end)){
                            for(int k = 0; k < ls.Count; k++)
                            {
                                if (i != j && i != k && j != k)
                                {
                                    tk = ls[k];
                                    if(intersect(ti.start,ti.end, tk.start, tk.end) && intersect(tj.start,tj.end, tk.start, tk.end)) { counter++; }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(counter/3);

                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
