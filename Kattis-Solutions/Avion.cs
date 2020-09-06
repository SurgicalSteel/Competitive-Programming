using System;
using System.Collections.Generic;

namespace Avion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            for(int i = 1; i <= 5; i++)
            {
                string s = Console.ReadLine();
                if (s.Contains("FBI"))
                {
                    l.Add(i);
                }
            }
            if (l.Count == 0)
            {
                Console.WriteLine("HE GOT AWAY!");
            }
            else
            {
                for(int i = 0; i < l.Count; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("{0}", l[i]);
                    }
                    else
                    {
                        Console.Write(" {0}", l[i]);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
