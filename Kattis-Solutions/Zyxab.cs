using System;
using System.Collections.Generic;
using System.Linq;

namespace Zyxab
{
    class Program
    {
        static void Main(string[] args)
        {
            //int maxi = int.MaxValue;
            int mini = 5;
            List<string> l = new List<string>();
            int n = int.Parse(Console.ReadLine());
            string s;
            for(int i = 0; i < n; i++) {l.Add(Console.ReadLine());}

            List<string> selected = (from x in l where x.Length >= mini && isNonRepetitive(x) select x).OrderBy(x => x.Length).ThenByDescending(x => x).ToList();
            if (selected.Count == 0) { Console.WriteLine("neibb!"); }
            else 
            {
                Console.WriteLine(selected[0]);
            }
        }

        static bool isNonRepetitive(string s)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            bool nonRep = true;
            for (int i = 0; i < s.Length; i++) 
            {
                if (d.ContainsKey(s.Substring(i, 1))){ nonRep = false;break; } 
                else { d.Add(s.Substring(i, 1), 1); }
            }
            return nonRep;
        }
    }
}
