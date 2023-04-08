using System;
using System.Collections.Generic;

namespace Class_Field_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string sa = Console.ReadLine();
            string sb = Console.ReadLine();
            List<string> sf = new List<string>();
            string s = "";
            for(int i = 0; i < sa.Length; i++) { sf.Add(sa.Substring(i, 1)); }
            for (int i = 0; i < sb.Length; i++) { sf.Add(sb.Substring(i, 1)); }
            sf.Sort();
            for (int i = 0; i < sf.Count; i++) { s += (sf[i]); }
            Console.WriteLine(s);
        }
    }
}
