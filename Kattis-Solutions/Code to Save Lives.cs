using System;

namespace Code_to_Save_Lives
{
    class Program
    {
        static void printRes(int n)
        {
            string s = "";
            string ns = n.ToString();
            for(int i = 0; i < ns.Length; i++)
            {
                if (i == 0) { s += ns.Substring(i, 1); }
                else { s += (" " + ns.Substring(i, 1)); }
            }
            Console.WriteLine(s);
        }
        static int add(string[] a, string[] b) 
        {
            int res = 0;
            string sa="", sb="";
            for(int i = 0; i < a.Length; i++) { sa += a[i]; }
            for (int i = 0; i < b.Length; i++) { sb += b[i]; }
            res += (int.Parse(sa) + int.Parse(sb));

            return res;
        }
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            string[] sa, sb;
            for(int i=0;i<tc;i++)
            {
                sa = Console.ReadLine().Split(' ');
                sb = Console.ReadLine().Split(' ');
                printRes(add(sa, sb));
            }
        }
    }
}
