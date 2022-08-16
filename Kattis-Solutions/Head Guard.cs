using System;

namespace Head_Guard
{
    class Program
    {
        static string compress(string s) 
        {
            string res = "",curr;
            int idx = 0,tmpc=1, idxa;
            bool breaker = false;
            while (idx < s.Length)
            {
                tmpc = 1;
                curr = s.Substring(idx, 1);
                idxa = idx+1;
                breaker = false;
                while(idxa<s.Length && !breaker)
                {
                    if (s.Substring(idxa,1) == curr) { idx++; tmpc++; } else { breaker = true; }
                    idxa++;
                }
                idx++;
                res += (tmpc.ToString() + curr);
            }
            return res;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            while (!string.IsNullOrEmpty(s)) 
            {
                Console.WriteLine(compress(s));
                s = Console.ReadLine();
            }
        }
    }
}
