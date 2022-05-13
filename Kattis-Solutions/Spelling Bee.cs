using System;
using System.Collections.Generic;
using System.Linq;

namespace Spelling_Bee
{
    class Program
    {

        static string sortgetdistinct(string s)
        {
            List<char> l = s.ToCharArray().ToList();
            l = l.Distinct().ToList();
            l.Sort();
            string r = "";
            for(int i = 0; i < l.Count; i++) { r += l[i].ToString(); }
            return r;
        }
        static bool containset(string supers, string subs) 
        {
            HashSet<char> superhc = supers.ToCharArray().ToList().Distinct().ToHashSet();
            HashSet<char> subhc = subs.ToCharArray().ToList().Distinct().ToHashSet();
            return subhc.IsSubsetOf(superhc);
        }
        static void Main(string[] args)
        {
            string raw = Console.ReadLine();
            string sraw = sortgetdistinct(raw);
            string s;
            int nd = int.Parse(Console.ReadLine());
            List<string> l = new List<string>();
            for (int i = 0; i < nd; i++)
            {
                s = Console.ReadLine();
                if (s.Length >= 4 && s.Contains(raw.Substring(0, 1)))
                {
                    if (containset(raw, s))
                    {
                        l.Add(s);
                    }
                }
            }
            for (int i = 0; i < l.Count; i++) { Console.WriteLine(l[i]); }
        }
    }
}
