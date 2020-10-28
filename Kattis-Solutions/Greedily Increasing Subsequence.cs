using System;
using System.Collections.Generic;

namespace Greedily_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] sarr = Console.ReadLine().Split(" ");
            int[] arr = new int[sarr.Length];
            int count = 0, currNum=0;
            for(int i = 0; i < n; i++)
            {arr[i] = int.Parse(sarr[i]);}
            List<int> l = new List<int>();
            for(int i = 0; i < n; i++)
            {
                if (i == 0) { 
                    count = 1; 
                    currNum = arr[i]; 
                    l.Add(currNum); 
                } 
                else
                {
                    if (arr[i] > currNum)
                    {
                        count++;
                        currNum = arr[i];
                        l.Add(currNum);
                    }
                    else { continue; }
                }
            }
            Console.WriteLine("{0}", l.Count);
            for(int i = 0; i < l.Count; i++)
            {
                if (i == 0) { Console.Write("{0}", l[i]); }
                else { Console.Write(" {0}", l[i]); }
            }
            Console.WriteLine();
        }
    }
}
