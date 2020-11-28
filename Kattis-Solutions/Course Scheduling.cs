using System;
using System.Collections.Generic;

namespace Course_Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,int>> d = new Dictionary<string, Dictionary<string,int>>();
            int n = int.Parse(Console.ReadLine());
            string[] sarr;
            string tkey;
            Dictionary<string, int> tds;
            List<string> keys = new List<string>();
            for (int i = 0; i < n; i++)
            {
                sarr = Console.ReadLine().Split(" ");
                if (d.ContainsKey(sarr[2]))
                { tds = d[sarr[2]]; }
                else
                { 
                    tds = new Dictionary<string, int>();
                    keys.Add(sarr[2]);
                }
                tkey = sarr[0] + " " + sarr[1];
                if (!tds.ContainsKey(tkey)) { tds.Add(tkey, 1); }
                d.Remove(sarr[2]);
                d.Add(sarr[2], tds);
            }
            keys.Sort();
            for(int i = 0; i < keys.Count; i++)
            {
                Console.WriteLine("{0} {1}", keys[i], d[keys[i]].Count);
            }
        }
    }
}
