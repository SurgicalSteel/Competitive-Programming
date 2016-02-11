using System;
using System.Linq;
using System.Collections.Generic;
namespace Statistics_Kattis
{
    class MainClass
    {
        static List<int> solve(string x){
            List<int> lr = new List<int>();
            List<int> tmp = new List<int>(); 
            List<string> arrs = x.Split().ToList();
            for(int i=1;i<arrs.Capacity;i++)
            {
                int xn;
                int.TryParse(arrs[i],out xn);
                tmp.Add(xn);
            }
            lr.Add(tmp.Min());
            lr.Add(tmp.Max());
            lr.Add(tmp.Max()-tmp.Min());
            return lr;
        }
        public static void Main(string[] args)
        {
            string inp=Console.ReadLine();
            int i = 1;
            while (!string.IsNullOrEmpty(inp))
            {
                List<int> resList = solve(inp);
                Console.WriteLine("Case {0}: {1} {2} {3}",i, resList[0], resList[1], resList[2]);
                inp = Console.ReadLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
