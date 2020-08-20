using System;
using System.Collections.Generic;
using System.Linq;

namespace costume_contest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<String, int> d = new Dictionary<string, int>();
            String s;
            List<String> sortedKeys = new List<string>();
            int count, mini = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                count = d.GetValueOrDefault(s, 0);
                count++;
                d.Remove(s);
                d.Add(s, count);
            }

            foreach (var key in d.Keys.ToList())
            {
                count = d.GetValueOrDefault(key, int.MaxValue);
                mini = Math.Min(count, mini);
            }
            foreach (var key in d.Keys.ToList())
            {
                count = d.GetValueOrDefault(key, int.MaxValue);
                if (count == mini)
                {
                    sortedKeys.Add(key);
                }
            }
            sortedKeys.Sort();
            for(int i = 0; i < sortedKeys.Count; i++)
            {
                Console.WriteLine(sortedKeys[i]);
            }
        }
    }
}
