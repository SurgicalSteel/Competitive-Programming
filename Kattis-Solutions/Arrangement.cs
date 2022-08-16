using System;

namespace Arrangement
{
    class Program
    {
        static string buildarr(int n) 
        {
            string s = "";
            for (int i = 0; i < n; i++) { s += "*"; }
            return s;
        }
        static void Main(string[] args)
        {
            int nr, np;
            string sm, sl;
            nr = int.Parse(Console.ReadLine());
            np = int.Parse(Console.ReadLine());
            if (nr == 1) { Console.WriteLine(buildarr(np)); }
            else
            {
                int mod = np % nr;
                if (mod == 0) 
                {
                    sm = buildarr(np / nr);
                    for(int x = 0; x < nr; x++) { Console.WriteLine(sm); }
                }
                else
                {
                    sm = buildarr(((np - mod) / nr) + 1);
                    sl = buildarr((np-mod)/nr);
                    int nm=mod, nl=nr-mod;
                    for(int x = 0; x < nm; x++) { Console.WriteLine(sm); }
                    for (int x = 0; x < nl; x++) { Console.WriteLine(sl); }
                }
            }
        }
    }
}
