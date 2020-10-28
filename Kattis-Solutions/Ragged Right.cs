using System;
using System.Collections.Generic;
using System.Linq;

namespace Ragged_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            string s = Console.ReadLine();
            while (!string.IsNullOrEmpty(s))
            {
                l.Add(s);
                s = Console.ReadLine();
            }
            int longest = l.Max(x => x.Length);
            long count = 0;
            for (int i = 0; i < l.Count - 1; i++) {
                count += (long)((longest - l[i].Length) * (longest - l[i].Length));
            }
            Console.WriteLine(count);
        }
    }
}
