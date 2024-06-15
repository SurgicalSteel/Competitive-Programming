using System;

namespace Luhns_Checksum_Algorithm
{
    class Program
    {
        static int addupDigit(int x)
        {
            int tot = 0;
            int tmod;
            while (x > 0)
            {
                tmod = x % 10;
                tot += tmod;
                x = x - tmod;
                x = x / 10;
            }
            return tot;
        }
        static int trans(int x)
        {
            x *= 2;
            if (x < 10) { return x; }
            return addupDigit(x);
        }
        static string checkLuhn(string s)
        {
            string res = "PASS";
            int tot = 0;
            string[] sarr = new string[s.Length];
            for(int i = 0; i < s.Length; i++) { sarr[i] = s.Substring(i, 1); }
            for(int x = s.Length - 1; x >= 0; x--)
            {
                if((s.Length - x) % 2 == 0)
                {
                    sarr[x] = trans(int.Parse(s.Substring(x, 1))).ToString();
                }
            }
            for (int i = 0; i < s.Length; i++) { tot += int.Parse(sarr[i]); }
            if(tot%10 > 0) { res = "FAIL"; }
            return res;
        }

        static void Main(string[] args)
        {
            int ntc = int.Parse(Console.ReadLine());
            string s;
            for(int i = 0; i < ntc; i++) 
            {
                s = Console.ReadLine();
                Console.WriteLine(checkLuhn(s));
            }
        }
    }
}
