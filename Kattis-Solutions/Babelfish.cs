using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babelfish_second_try
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            string s = Console.ReadLine();
            while (!string.IsNullOrEmpty(s))
            {
                string[] sp = s.Split();
                d.Add(sp[1],sp[0]);
                s = Console.ReadLine();
            }
            s = Console.ReadLine();
            while (!string.IsNullOrEmpty(s))
            {
                if (d.ContainsKey(s)) { Console.WriteLine(d[s]); }
                else
                {Console.WriteLine("eh");}
                s = Console.ReadLine();
            }
        }
    }
}
