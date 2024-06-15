using System;
using System.Collections.Generic;
namespace Mean_Words
{
    class Program
    {
        static char getavg(List<char> lc)
        {
            int count = lc.Count;
            int tot = 0;
            for(int i = 0; i < lc.Count; i++) { tot += lc[i]; }
            return (char) (tot / count);
        }
        static void Main(string[] args)
        {
            int nw = int.Parse(Console.ReadLine());
            int maxlen = 0;
            string temps;
            List<string> ls = new List<string>();
            char[][] matchar = new char[nw][];
            char[] charr;
            char tempchar;
            List<char> lc;
            for (int i = 0; i < nw; i++)
            {
                temps = Console.ReadLine();
                maxlen = Math.Max(maxlen, temps.Length);
                ls.Add(temps);
            }

            for (int i = 0; i < nw; i++)
            {
                temps = ls[i];
                charr = temps.ToCharArray();
                matchar[i] = new char[maxlen];
                for (int j = 0; j < maxlen; j++)
                {
                    if (j < charr.Length)
                    { matchar[i][j] = charr[j]; }
                    else { matchar[i][j] = '\0'; }
                }
            }

            charr = new char[maxlen];
            for (int i = 0; i < maxlen; i++)
            {
                lc = new List<char>();
                for(int j = 0; j < nw; j++)
                {
                    if(matchar[j][i]!= '\0') { lc.Add(matchar[j][i]); }
                }
                charr[i] = getavg(lc);
            }
            string res = new string(charr);
            Console.WriteLine(res);
        }
    }
}
