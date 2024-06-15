using System;
using System.Collections.Generic;
namespace Bannord
{
    class Program
    {
        static string gen(int len)
        {
            string s = "";
            for(int i = 0; i < len; i++) { s += "*"; }
            return s;
        }
        static string trans(string curr, Dictionary<string,int> dban)
        {
            for(int i = 0; i < curr.Length; i++)
            {
                if (dban.ContainsKey(curr.Substring(i, 1)))
                {
                    return gen(curr.Length);
                }
            }
            return curr;
        }
        static void Main(string[] args)
        {
            string sban = Console.ReadLine();
            Dictionary<string, int> dban = new Dictionary<string, int>();
            for(int i = 0; i < sban.Length; i++) { dban.Add(sban.Substring(i, 1), 1); }

            string[] sarr = Console.ReadLine().Split(' ');
            string res = "";
            for(int i = 0; i < sarr.Length; i++)
            {
                if (i == 0) { res += trans(sarr[i], dban); }
                else { res += (" " + trans(sarr[i], dban)); }
            }
            Console.WriteLine(res);
        }
    }
}
