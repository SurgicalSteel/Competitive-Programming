using System;
using System.Collections.Generic;
namespace Eiginnofn
{
    class Program
    {
        static void Main(string[] args)
        {
            int nd, nq;
            string[] sarr;
            string stemp,last;
            nd = int.Parse(Console.ReadLine());
            Dictionary<string, string> d = new Dictionary<string, string>();
            for(int i = 0; i < nd; i++)
            {
                sarr = Console.ReadLine().Split(' ');
                if (sarr.Length == 1) { d.Add(sarr[0], ""); } 
                else if(sarr.Length>1){ d.Add(sarr[0], sarr[1]); }
            }
            nq = int.Parse(Console.ReadLine());
            for(int i = 0; i < nq; i++)
            {
                stemp = Console.ReadLine();
                if (d.ContainsKey(stemp))
                {
                    last = d[stemp];
                    if (last.Length == 0)
                    {
                        Console.WriteLine("Jebb");
                    }
                    else
                    {
                        Console.WriteLine("Neibb en {0} {1} er heima",stemp, last);
                    }
                }
                else
                {
                    Console.WriteLine("Neibb");
                }
            }
        }
    }
}
