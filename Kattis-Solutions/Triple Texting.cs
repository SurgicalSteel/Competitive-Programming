using System;

namespace TripleTexting
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int len = s.Length;
            string a, b, c;
            a = s.Substring(0, len / 3);
            b = s.Substring(len / 3, len / 3);
            c = s.Substring(len - (len / 3), len / 3);
           if (a == b || a == c)
            {
                Console.WriteLine(a);
            }else if(b == c)
            {
                Console.WriteLine(c);
            }
        }
    }
}
