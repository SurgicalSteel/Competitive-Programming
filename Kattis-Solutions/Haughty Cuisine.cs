using System;
using System.Collections.Generic;
namespace Haughty_Cuisine
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] sarr;
            int nr=0;
            List<string> lm = new List<string>();
            for(int i = 0; i < n; i++) 
            {
                sarr = Console.ReadLine().Split(' ');
                if (i == 0) 
                {
                    for(int x = 0; x < sarr.Length; x++) 
                    {
                        if (x == 0) { nr = int.Parse(sarr[x]); } else { lm.Add(sarr[x]); }
                    }
                }
            }
            //lm.Sort();
            Console.WriteLine(nr);
            for(int i = lm.Count - 1; i >= 0; i--) { Console.WriteLine(lm[i]); }
        }
    }
}

