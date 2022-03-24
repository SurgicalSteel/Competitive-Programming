using System;
using System.Collections.Generic;

namespace Social_Distancing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr;
            int nseat, nocc;
            sarr = Console.ReadLine().Split(' ');
            nseat = int.Parse(sarr[0]);
            nocc = int.Parse(sarr[1]);
            sarr = Console.ReadLine().Split(' ');
            List<int> l = new List<int>();

            int count = 0;
            int tempsegment;
            int countsegment=0;
            if (nocc == 1) 
            {
                if ((nseat - 2) % 2 == 1)
                {
                    nseat--;
                }
                count = (nseat - 2) / 2;
            } 
            else 
            {
                for(int i = 0; i <= sarr.Length; i++)
                {
                    if (i == sarr.Length) { l.Add(int.Parse(sarr[0]) + nseat); }
                    else { l.Add(int.Parse(sarr[i])); }
                }

                for(int i = 1; i < l.Count; i++) 
                {
                    tempsegment = l[i] - l[i - 1];
                    if (tempsegment % 2 == 1) { tempsegment--; }
                    countsegment += tempsegment;
                }
                count = (countsegment / 2) - nocc;
            }
            

            Console.WriteLine(count);
        }
    }
}
