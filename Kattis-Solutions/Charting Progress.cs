using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charting_Progress
{
    class Program
    {
        static void solve(List<int> myplot, int lenstr)
        {
            int nr = myplot.Count;
            int lastpos = 0;
            string build;
            string[] resarr = new string[nr];
            for(int i = nr - 1; i >= 0; i--)
            {
                build = "";
                for (int x = 0; x < lenstr; x++)
                {
                    if (x >= lastpos && x < (myplot[i] + lastpos) && myplot[i]!=0)
                    { build += "*"; }
                    else { build += "."; }
                }
                lastpos += myplot[i];
                resarr[i] = build;
            }
            for(int i=0;i< nr; i++) { Console.WriteLine(resarr[i]); }
        }
        static void Main(string[] args)
        {
            string tmps = Console.ReadLine();
            while (!string.IsNullOrEmpty(tmps))
            {
                List<int> myplot = new List<int>();
                int len=tmps.Length;
                int nasterix = 0;
                while (!string.IsNullOrEmpty(tmps))
                {
                    nasterix = 0;
                    for(int i = 0; i < len; i++)
                    {
                        if (tmps.Substring(i, 1).Equals("*")) { nasterix++; }
                    }
                    myplot.Add(nasterix);
                    tmps = Console.ReadLine();
                }
                solve(myplot, len);
                Console.WriteLine("");
                tmps = Console.ReadLine();
            }
        }
    }
}
