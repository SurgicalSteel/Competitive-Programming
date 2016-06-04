using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin
{
    class Program
    {
        static bool isalive(string s)
        { return s.Substring(0, 1).ToLower().Equals("a") || s.Substring(0, 1).ToLower().Equals("i") || s.Substring(0, 1).ToLower().Equals("u") || s.Substring(0, 1).ToLower().Equals("e") || s.Substring(0, 1).ToLower().Equals("o") || s.Substring(0, 1).ToLower().Equals("y"); }
        static bool islive(string s)
        { return s.Equals("a") || s.Equals("i") || s.Equals("u") || s.Equals("e") || s.Equals("o") || s.Equals("y"); }
        static string rotate(string s)
        {
            int idx = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (islive(s.Substring(i, 1)))
                {
                    idx = i;
                    break;
                }
            }
            return s.Substring(idx) + s.Substring(0, idx);
        }
        static void processtr(string s)
        {
            string[] cs = s.Split();
            for (int i = 0; i < cs.Length; ++i)
            {
                if (isalive(cs[i])) { Console.Write(cs[i] + "yay"); }
                else
                { Console.Write(rotate(cs[i]) + "ay"); }
                if (i + 1 < cs.Length) { Console.Write(" "); }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            while (!string.IsNullOrEmpty(s))
            {
                processtr(s);
                s = Console.ReadLine();
            }
        }
    }
}
