using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptice
{
    class Program
    {
        static string genadrian(int n)
        {
            string res = "";
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 1) { res += "A"; }
                else if (i % 3 == 2) { res += "B"; }
                else { res += "C"; }
            }
            return res;
        }
        static string genbruno(int n)
        {
            string res = "";
            for (int i = 1; i <= n; i++)
            {
                if (i % 4 == 1 || i % 4 == 3) { res += "B"; }
                else if (i % 4 == 2) { res += "A"; }
                else { res += "C"; }
            }
            return res; 
        }
        static string gengoran(int n)
        {
            string res = "";
            for (int i = 1; i <= n; i++)
            {
                if (i % 6 == 1 || i % 6 == 2) { res += "C"; }
                if (i % 6 == 3 || i % 6 == 4) { res += "A"; }
                if (i % 6 == 5 || i % 6 == 0) { res += "B"; }
            }
            return res;
        }
        static int getsimilarity(string a, string b)
        {
            int i = 0;
            int ctr = 0;
            while (i < a.Length)
            {
                if (a[i] == b[i]) { ctr++; }
                i++;
            }
            return ctr;
        }
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            string ans = Console.ReadLine();
            int simadrian = getsimilarity(ans, genadrian(len));
            int simbruno = getsimilarity(ans, genbruno(len));
            int simgoran = getsimilarity(ans, gengoran(len));
            int maxi = Math.Max(simadrian, Math.Max(simbruno, simgoran));
            List<string> names = new List<string>();
            if (simadrian == maxi) { names.Add("Adrian"); }
            if (simbruno == maxi) { names.Add("Bruno"); }
            if (simgoran == maxi) { names.Add("Goran"); }
            Console.WriteLine(maxi);
            for (int i = 0; i < names.Count; i++) { Console.WriteLine(names[i]); }
        }
    }
}
