using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pervasive_Heart_Monitor
{
    class Program
    {
        static bool checknum(string s)
        {
            return (s.Contains("1") || s.Contains("2") || s.Contains("3") || s.Contains("4") || s.Contains("5") || s.Contains("6") || s.Contains("7") || s.Contains("8") || s.Contains("9") || s.Contains("."));
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            while (!string.IsNullOrEmpty(s))
            {
                float total=0;
                int n=0;
                string name = "";
                string[] ssplit = s.Split();
                for(int i = 0; i < ssplit.Length; i++)
                {
                    if (!checknum(ssplit[i])) { name += (ssplit[i] + " "); }
                    else
                    {
                        total += float.Parse(ssplit[i]);
                        n++;
                    }
                }
                Console.WriteLine("{0:F6} {1}", (float)(total / n), name);
                s = Console.ReadLine();
            }
        }
    }
}
