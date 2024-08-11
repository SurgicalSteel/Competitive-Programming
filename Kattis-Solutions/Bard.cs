using System;
using System.Collections.Generic;
using System.Linq;
namespace Bard
{
    class Program
    {
        static void printset(HashSet<int> set, int idx)
        {
            string s = "";
            foreach(int x in set) { if (s == "") { s += x.ToString(); } else { s += (" " + x.ToString()); }}
            Console.WriteLine("DEBUG SET {0}: {1}",idx, s);
        }
        static void Main(string[] args)
        {
            int nv = int.Parse(Console.ReadLine());
            int ne = int.Parse(Console.ReadLine());
            HashSet<int> tempknows = new HashSet<int>();
            string[] sarr;
            bool isBardPresent;
            List<HashSet<int>> vknows = new List<HashSet<int>>();
            for(int i = 0; i < nv + 1; i++) { vknows.Add(new HashSet<int>()); }
            for(int x = 0; x < ne; x++)
            {
                tempknows = new HashSet<int>();
                sarr = Console.ReadLine().Split();
                sarr = sarr.Skip(1).ToArray();
                //Console.WriteLine("DEBUG SARR LENGTH {0}", sarr.Length);
                isBardPresent = sarr.Contains("1");
                if (isBardPresent)
                {
                    tempknows = new HashSet<int>();
                    for (int i = 0; i < sarr.Length; i++)
                    {
                        tempknows = vknows[int.Parse(sarr[i])];
                        tempknows.Add(x);
                        vknows[int.Parse(sarr[i])] = tempknows;
                        //printset(vknows[int.Parse(sarr[i])], int.Parse(sarr[i]));
                    }
                }
                else
                {
                    tempknows = new HashSet<int>();
                    for (int i = 0; i < sarr.Length; i++)
                    {
                        tempknows.UnionWith(vknows[int.Parse(sarr[i])]);
                    }
                    for (int i = 0; i < sarr.Length; i++)
                    {
                        vknows[int.Parse(sarr[i])].UnionWith(tempknows);
                        
                        //printset(vknows[int.Parse(sarr[i])], int.Parse(sarr[i]));
                        //Console.WriteLine("DEBUG {0} {1}", sarr[i], tempknows.Count);
                    }
                }
                //Console.WriteLine("evening {0}", x);
                //for(int z = 1; z < vknows.Count; z++) { printset(vknows[z], z); }
            }
            int max = 0;
            string stemp = "";
            List<int> vfinal = new List<int>();
            for (int i = 1; i < vknows.Count; i++)
            { max = Math.Max(max, vknows[i].Count); }

            for (int i = 1; i < vknows.Count; i++)
            {
                if (i == 1) { max = vknows[i].Count; vfinal.Add(i); }
                else { if (vknows[i].Count == max) { vfinal.Add(i); } }
                //Console.WriteLine("DEBUG I={0} C={1}", i, vknows[i].Count);
                //if (i == 7) { stemp = ""; foreach (int x in vknows[i]) { stemp += (" " + x.ToString()); } Console.WriteLine(stemp); }
            }
            for(int i = 0; i < vfinal.Count; i++) { Console.WriteLine(vfinal[i]); }
            //Console.WriteLine("MAX {0}", max);
        }
    }
}
