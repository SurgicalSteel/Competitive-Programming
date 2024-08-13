using System;
using System.Collections.Generic;

namespace Falling_Snow
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(" ");
            int nr = int.Parse(sarr[0]);
            int nc = int.Parse(sarr[1]);
            string s;
            List<List<string>> mcbase = new List<List<string>>();
            for(int x = 0; x < nr; x++)
            {
                s = Console.ReadLine();
                for(int y = 0; y < nc; y++)
                {
                    if(x==0) { mcbase.Add(new List<string>()); }
                    mcbase[y].Add(s.Substring(y, 1));
                }
            }
            for(int x = 0; x < mcbase.Count; x++){mcbase[x].Sort();}
            List<string> lines = new List<string>();
            for(int x = 0; x < nr; x++) { lines.Add(""); }
            for (int x = 0; x < nr; x++)
            {
                for (int y = 0; y < nc; y++)
                {
                    lines[x] += mcbase[y][x];
                }
            }
            for (int x = 0; x < nr; x++) { Console.WriteLine(lines[x]); }
        }
    }
}
