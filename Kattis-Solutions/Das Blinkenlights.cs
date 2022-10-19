using System;
namespace Das_Blinkenlights
{
    class Program
    {
        static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
        static int lcm(int a, int b)
        {
            return a* b / gcd(a, b);
        }
        static void Main(string[] args)
        {
            int p, q, s;
            string[] sarr = Console.ReadLine().Split(' ');
            p = int.Parse(sarr[0]);
            q = int.Parse(sarr[1]);
            s = int.Parse(sarr[2]);

            bool same = false;
            int lcmv = lcm(p, q);
            same = lcmv >= 1 && lcmv <= s;
            Console.WriteLine(same ? "yes" : "no");
            
        }
    }
}
