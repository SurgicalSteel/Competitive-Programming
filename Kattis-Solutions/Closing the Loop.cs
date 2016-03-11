using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closing_the_Loop_Kattis
{
    class Program
    {
        struct segment
        {
            public segment(int l, string c)
            {
                this.col = c;
                this.len = l;
                this.used = false;
            }
            public string col;
            public int len;
            public bool used;
        };
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            int x = tc;
            while (tc > 0)
            {
                int sz = int.Parse(Console.ReadLine());
                string[] reader = Console.ReadLine().Split();
                List<segment> ls = new List<segment>();
                for(int i=0;i< sz;i++)
                {ls.Add(new segment(int.Parse(reader[i].Substring(0, reader[i].Length - 1)), reader[i].Substring(reader[i].Length - 1)));}
                List<segment> ror = new List<segment>();
                List<segment> bor = new List<segment>();
                ror = (from yay in ls orderby yay.len descending where yay.col=="R" select yay).ToList();
                bor = (from nay in ls orderby nay.len descending where nay.col == "B" select nay).ToList();
                
                int szmin = 0,length=0;
                if(ror.Count>0&&bor.Count>0)
                {
                    szmin = (Math.Min(ror.Count, bor.Count));
                    for (int it = 0; it < szmin; it++)
                    { length += ((ror[it].len - 1) + (bor[it].len - 1)); }
                }
                Console.WriteLine("Case #{0}: {1}", x - tc + 1, length);
                tc--;
            }
            Console.ReadLine();
        }
    }
}
