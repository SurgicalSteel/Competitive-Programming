using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Poker_Hand
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            int maxi = 0,tmpCount;
            string tmpKey;
            String[] arr = Console.ReadLine().Split(" ");
            //Console.WriteLine(arr[0]);
            for(int i = 0; i < arr.Length; i++)
            {
                tmpKey = arr[i].Substring(0, 1);
               //Console.WriteLine(tmpKey);
                tmpCount = 1;
                if (d.ContainsKey(tmpKey))
                {
                    tmpCount = d[tmpKey] +1;
                    d.Remove(tmpKey);
                }
                d.Add(tmpKey, tmpCount);
            }
            foreach(string key in d.Keys)
            {
                //Console.WriteLine(d[key]);
                maxi = Math.Max(maxi, d[key]);
            }
            Console.WriteLine(maxi);
        }
    }
}
