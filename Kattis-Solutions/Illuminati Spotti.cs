using System;
using System.Collections.Generic;
namespace Illuminati_Spotti
{

    class Program
    {

        struct comb
        {
            public int a;
            public int b;
            public int c;
            public string srep;
            public comb(int x, int y, int z, string s) { this.a = x; this.b = y; this.c = z; this.srep = s; }
        }

        static string getsortedsrep(int a, int b, int c)
        {
            if (a < b && b < c){ return String.Format("{0}{1}{2}", a, b, c);}
            if (a < c && c < b) { return String.Format("{0}{1}{2}", a, c, b); }
            if (b < a && a < c) { return String.Format("{0}{1}{2}", b, a, c); }
            if (b < c && c < a) { return String.Format("{0}{1}{2}", b, c, a); }
            if (c < b && b < a) { return String.Format("{0}{1}{2}", c, b, a); }
            if (c < a && a < b) { return String.Format("{0}{1}{2}", c, a, b); }
            return "";
        }

        

        static string getsrep(int a, int b, int c) { return String.Format("{0}{1}{2}",a,b,c); }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s, ss="";
            string[] sarr;
            int[][] m = new int[n][];
            for (int i = 0; i < n; i++) 
            { 
                m[i] = new int[n];
                sarr = Console.ReadLine().TrimEnd().Split(' ');
                for(int j = 0; j < sarr.Length; j++) { m[i][j] = int.Parse(sarr[j]); }
            }

            Dictionary<string, int> dsrepcomb = new Dictionary<string, int>();
            List<comb> lc = new List<comb>();
            //int y, z;
            int c = 0;
            for(int x = 0; x < n-2; x++) 
            {
                for (int y = x + 1; y < n - 1; y++)
                {
                    if (m[x][y] == 1)
                    {
                        for (int z = y + 1; z < n; z++)
                        {
                            if (m[y][z] == 1 && m[x][z] == 1)
                            {
                                c++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(c);
            /*
            int c = 0;
            Dictionary<string, int> dsortedsrep = new Dictionary<string, int>();
            for(int i = 0; i < lc.Count; i++)
            {
                if(m[lc[i].a][lc[i].b] == 1 && m[lc[i].b][lc[i].c] == 1 && m[lc[i].a][lc[i].c] == 1) 
                {
                    s = getsortedsrep(lc[i].a, lc[i].b, lc[i].c);
                    if (!dsortedsrep.ContainsKey(s)) { dsortedsrep.Add(s, 1); } 
                }
            }
            c = dsortedsrep.Count;
            Console.WriteLine(c);
            */
        }
    }
}

