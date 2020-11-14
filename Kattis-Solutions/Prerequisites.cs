using System;
using System.Collections.Generic;
using System.Linq;

namespace Prerequisites
{
    class Program
    {
        static bool isPass(Dictionary<string,int> taken, string[] sarra)
        {
            int call = int.Parse(sarra[0]), mini = int.Parse(sarra[1]);
            int count = 0;

            for(int i = 2; i < sarra.Length; i++)
            {if (taken.ContainsKey(sarra[i])) { count++; }}

            return count >= mini;
        }
        static void Main(string[] args)
        {
            string[] sarr,sarra;
            int nct, ncat;
            bool passAll;
            Dictionary<string, int> d;
            string tcmark = Console.ReadLine();
            while(tcmark!= "0")
            {
                passAll = true;
                sarr = tcmark.Split(" ");
                nct = int.Parse(sarr[0]);
                ncat = int.Parse(sarr[1]);
                d = new Dictionary<string, int>();
                sarra = Console.ReadLine().Split(" ");
                for (int i = 0; i < nct; i++) { d.Add(sarra[i], 1); }
                for(int i = 0; i < ncat; i++)
                {
                    sarra = Console.ReadLine().Split(" ");
                    passAll = passAll && isPass(d, sarra);
                }
                if (passAll) { Console.WriteLine("yes"); } else { Console.WriteLine("no"); }

                tcmark = Console.ReadLine();
            }
        }
    }
}
