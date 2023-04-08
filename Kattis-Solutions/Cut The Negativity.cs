using System;
using System.Collections.Generic;
using System.Linq;

namespace Cut_The_Negativity
{
    class Program
    {
        struct res
        {
            public int from;
            public int to;
            public int dist;
            public res(int f, int t, int d) { this.from = f; this.to = t; this.dist = d; }
        }
        static int[] transIns(string s, int sz)
        {
            int[] arr = new int[sz];
            string[] sarr = s.Split(' ');
            for(int i = 0; i < sz; i++) { arr[i] = int.Parse(sarr[i]); }
            return arr;
        }
        static void Main(string[] args)
        {
            int sz = int.Parse(Console.ReadLine());
            int[][] mat = new int[sz][];
            for(int x = 0; x < sz; x++) { mat[x] = transIns(Console.ReadLine(), sz); }
            List<res> reslist = new List<res>();
            for (int i = 0; i < sz; i++)
            {
                for(int j = 0; j < sz; j++)
                {
                    if(mat[i][j]>0 && i != j) { reslist.Add(new res(i + 1, j + 1, mat[i][j])); }
                }
            }
            List<res> sorted = reslist.OrderBy(x => x.from).ThenBy(x => x.to).ToList();
            Console.WriteLine(sorted.Count);
            foreach(res x in sorted)
            {
                Console.WriteLine("{0} {1} {2}", x.from, x.to, x.dist);
            }
        }
    }
}
