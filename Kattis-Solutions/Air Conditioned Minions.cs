using System;
using System.Collections.Generic;
using System.Linq;

namespace Air_Conditioned_Minions
{
    internal class Program
    {
        struct minion
        {
            public int mini { get; set; }
            public int maxi { get; set; }
            public minion(string mi, string ma)
            {
                this.mini = int.Parse(mi);
                this.maxi = int.Parse(ma);
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] sarr;
            List<minion> lm = new List<minion>();
            for(int i= 0; i < num; i++)
            {
                sarr = Console.ReadLine().Split();
                lm.Add(new minion(sarr[0], sarr[1]));
            }
            List<minion> sorted = lm.OrderBy(m => m.maxi).ThenBy(m => m.mini).ToList();
            int nroom = 1;
            int mintemp = sorted[0].maxi;
            for(int i = 1; i < sorted.Count; i++) 
            {
                if (sorted[i].mini > mintemp)
                {
                    mintemp = sorted[i].maxi;
                    nroom++;
                }
            }
            Console.WriteLine(nroom);
        }
    }
}
