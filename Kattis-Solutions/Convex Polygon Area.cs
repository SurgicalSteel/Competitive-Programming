using System;
using System.Collections.Generic;

namespace Convex_Polygon_Area
{
    class Program
    {
        struct Point
        {
            public double x { get; set; }
            public double y { get; set; }
            public Point(double px, double py)
            {
                this.x = px;
                this.y = py;
            }
            public Point(int px, int py)
            {
                this.x = (double)px;
                this.y = (double)py;
            }
        }
        static double CalculateAreaWithShoelaceFormula(List<Point> points)
        {
            double area, sideA = 0, sideB = 0;
            List<double> lx = new List<double>();
            List<double> ly = new List<double>();

            for (int i = 0; i < points.Count; i++)
            {
                lx.Add(points[i].x);
                ly.Add(points[i].y);
            }

            lx.Add(lx[0]);
            ly.Add(ly[0]);

            for (int i = 0; i < points.Count; i++)
            {
                sideA += (lx[i] * ly[i + 1]);
                sideB += (ly[i] * lx[i + 1]);
            }

            area = Math.Abs(0.5 * (sideA - sideB));

            return area;
        }

        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            List<Point> lp;
            string[] sarr;
            double area;
            for(int i = 0; i < tc; i++) 
            {
                sarr = Console.ReadLine().Split(' ');
                lp = new List<Point>();
                for(int x = 1; x < sarr.Length-1; x += 2)
                {
                    lp.Add(new Point(int.Parse(sarr[x]), int.Parse(sarr[x + 1])));
                }
                area = CalculateAreaWithShoelaceFormula(lp);
                Console.WriteLine("{0:F6}", area);
            }
        }
    }
}
