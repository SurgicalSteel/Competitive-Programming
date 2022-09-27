using System;
using System.Collections.Generic;
namespace Heirs_Dilemma
{
    class Program
    {
        static bool check(int n)
        {
            string ns = n.ToString();
            string t;
            Dictionary<string, int> d = new Dictionary<string, int>();
            for (int i = 0; i < ns.Length; i++) {
                t = ns.Substring(i, 1);
                if (d.ContainsKey(t) || t == "0") { return false; }
                if (n % int.Parse(t) > 0) { return false; }
                d.Add(t, 1);
            }
            return true;
        }
        static void Main(string[] args)
        {
            int low, high, count=0;
            string[] sarr = Console.ReadLine().Split(' ');
            low = int.Parse(sarr[0]);
            high = int.Parse(sarr[1]);

            for(int i = low; i <= high; i++) { if (check(i)) { count++; } }
            Console.WriteLine(count);
        }
    }
}
