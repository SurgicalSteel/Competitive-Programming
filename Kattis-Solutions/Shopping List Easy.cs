using System;
using System.Collections.Generic;
using System.Linq;
namespace Shopping_List_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(' ');
            int l = int.Parse(sarr[0]);
            List<List<string>> lhss = new List<List<string>>();
            List<string> temp;
            List<string> res = new List<string>();
            Dictionary<string, int> d = new Dictionary<string, int>(); 
            for(int x = 0; x < l; x++) 
            {
                sarr = Console.ReadLine().Split();
                for(int i = 0; i < sarr.Length; i++) { if (!d.ContainsKey(sarr[i])) { d.Add(sarr[i], 1); } }
                temp = new List<string>(sarr); 
                lhss.Add(temp);
            }
            bool all;
            foreach(string k in d.Keys)
            {
                all = true;
                for(int i = 0; i < lhss.Count; i++) 
                {
                    if (!lhss[i].Contains(k)) { all = false;break; }
                }
                if (all) { res.Add(k); }
            }
            res = (from fuck in res orderby fuck select fuck).ToList(); 
            Console.WriteLine(res.Count);
            for(int i = 0; i < res.Count; i++) { Console.WriteLine(res[i]); }
            
        }
    }
}
