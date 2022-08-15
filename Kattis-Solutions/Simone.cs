using System;
using System.Collections.Generic;
using System.Linq;
namespace Simone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr;
            int nc, szocc;
            sarr = Console.ReadLine().Split(' ');
            szocc = int.Parse(sarr[0]);
            nc = int.Parse(sarr[1]);
            int[] counterArr = new int[nc + 1];
            counterArr[0] = -1; //empty
            for (int i = 1; i < nc + 1; i++) { counterArr[i] = 0; }
            sarr = Console.ReadLine().Split(' ');
            for (int i = 0; i < sarr.Length; i++)
            {
                counterArr[int.Parse(sarr[i])]++;
            }
            int mini = int.MaxValue;
            for (int i = 1; i < nc + 1; i++)
            {
                if (counterArr[i] < mini) { mini = counterArr[i]; }
            }
            int minicounter = 0;
            string s = "";
            for (int i = 1; i < nc + 1; i++)
            {
                if (counterArr[i] == mini)
                {
                    minicounter++;
                    if (s.Length == 0) { s += i.ToString(); } else { s += (" " + i.ToString()); }// miniIdx.Add(i); 
                }
            }
            Console.WriteLine(minicounter);
            Console.WriteLine(s);
        }
    }
}
