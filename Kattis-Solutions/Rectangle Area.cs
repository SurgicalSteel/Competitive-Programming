using System;

namespace Rectangle_Area
{
    class Program
    {
        static float abs(float xa, float xb)
        {
            if (xa > xb) { return xa - xb; }
            return xb - xa;
        }
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(' ');
            float area, ax, ay, bx, by;
            ax = float.Parse(sarr[0]);
            ay = float.Parse(sarr[1]);
            bx = float.Parse(sarr[2]);
            by = float.Parse(sarr[3]);
            area = abs(by,ay) * abs(bx,ax);
            Console.WriteLine("{0:F3}", area);
        }
    }
}
