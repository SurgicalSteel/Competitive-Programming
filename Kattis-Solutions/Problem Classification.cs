using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_Classification
{
    class Program
    {
        static void Main(string[] args)
        {
            int np = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> keywordCategoryMap = new Dictionary<string, List<string>>();
            Dictionary<string, int> categoryCounterMap = new Dictionary<string, int>();
            string[] sarr;
            List<string> tpl;
            for(int i = 0; i < np; i++) 
            {
                sarr = Console.ReadLine().Split(' ');
                categoryCounterMap.Add(sarr[0], 0);
                for(int j = 2; j < sarr.Length; j++)
                {
                    if (keywordCategoryMap.ContainsKey(sarr[j]))
                    {
                        tpl = keywordCategoryMap[sarr[j]];
                        tpl.Add(sarr[0]);
                        keywordCategoryMap.Remove(sarr[j]);
                        keywordCategoryMap.Add(sarr[j], tpl);
                    }
                    else
                    {
                        tpl = new List<string>();
                        tpl.Add(sarr[0]);
                        keywordCategoryMap.Add(sarr[j], tpl);
                    }
                }
            }

            string s = Console.ReadLine();
            int temp;
            int maxi = 0;
            while (!string.IsNullOrEmpty(s))
            {
                sarr = s.Split(' ');
                for(int i = 0; i < sarr.Length; i++) 
                {
                    if (keywordCategoryMap.ContainsKey(sarr[i])) 
                    {
                        tpl = keywordCategoryMap[sarr[i]];
                        for(int j = 0; j < tpl.Count; j++)
                        {
                            temp = categoryCounterMap[tpl[j]];
                            temp += 1;
                            if (temp > maxi) { maxi = temp; }
                            categoryCounterMap.Remove(tpl[j]);
                            categoryCounterMap.Add(tpl[j],temp);
                        }
                    }
                }
                s = Console.ReadLine();
            }
            List<string> keys = new List<string>();
            foreach (string tmpkey in categoryCounterMap.Keys){ if (categoryCounterMap[tmpkey] == maxi) { keys.Add(tmpkey); } }
            keys = keys.OrderBy(x => x).ToList();
            for(int x = 0; x < keys.Count; x++) { Console.WriteLine(keys[x]); }
        }
    }
}
