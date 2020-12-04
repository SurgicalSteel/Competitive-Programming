using System;

namespace The_Owl_and_The_Fox
{
    class Program
    {
        static string decrement(string s)
        {
            int a = int.Parse(s);
            a--;
            return a.ToString();
        }
        static int merge(string[] sarr)
        {
            string sres = "";
            for(int i = 0; i < sarr.Length; i++) { sres += sarr[i]; }
            return int.Parse(sres);
        }
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            int tidx, n, res;
            string s,oneFound;
            string[] sarr;
            char[] charr;
            for(int x = 0; x < tc; x++)
            {
                charr = Console.ReadLine().ToCharArray();
                sarr = new string[charr.Length];
                for(int i = 0; i < charr.Length; i++) { sarr[i] = charr[i].ToString(); }
                tidx = charr.Length - 1;
                for (int i = charr.Length - 1; i >= 0; i--) 
                { 
                    if (sarr[i] != "0") 
                    { 
                        tidx = i; 
                        break; 
                    } 
                }
                oneFound = decrement(sarr[tidx]);
                sarr[tidx] = oneFound;
                res = merge(sarr);
                
                Console.WriteLine(res);
            }
        }
    }
}
