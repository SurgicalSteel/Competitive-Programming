using System;

namespace Broken_Swords
{
    class Program
    {
        static int tt = 0, tb = 0, tl = 0, tr = 0;

        static void read(string s)
        {
            if (s.Substring(0, 1) == "0") { tt++; }
            if (s.Substring(1, 1) == "0") { tb++; }
            if (s.Substring(2, 1) == "0") { tl++; }
            if (s.Substring(3, 1) == "0") { tr++; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s;
            for(int i = 0; i < n; i++) 
            {
                s = Console.ReadLine();
                read(s);
            }
            int stb = tt + tb;
            int slr = tl + tr;
            int rtb = stb % 2;
            int rlr = slr % 2;
            stb -= rtb;
            slr -= rlr;

            int mini = Math.Min(stb, slr);

            rtb += (stb - mini);
            rlr += (slr - mini);

            Console.WriteLine("{0} {1} {2}", mini / 2, rtb, rlr);
        }
    }
}
