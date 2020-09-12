using System;
using System.Collections.Generic;

namespace Keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> d = new Dictionary<string,int>();
            int n = int.Parse(Console.ReadLine());
            string stemp;
            for (int i = 0; i < n; i++) {
                stemp = Console.ReadLine().ToLower();
                stemp = stemp.Replace('-', ' ');
                if (!d.ContainsKey(stemp))
                {
                    d.Add(stemp, 1);
                }
            }
            Console.WriteLine(d.Count);
        }
    }
}
