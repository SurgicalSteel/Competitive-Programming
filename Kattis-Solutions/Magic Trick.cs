using System;
using System.Collections.Generic;
namespace Magic_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Dictionary<string, int> d = new Dictionary<string, int>();
            bool flag = true;
            string x;
            for (int i = 0; i < s.Length; i++)
            {
                x = s.Substring(i, 1);
                if (d.ContainsKey(x)) { flag = false; break; } else { d.Add(x, 1); }
            }
            if (flag) { Console.WriteLine("1"); } else { Console.WriteLine("0"); }
        }
    }
}
