using System;
using System.Collections.Generic;
using System.Linq;

namespace Veci
{
    class Program
    {

        static List<string> permute(List<string> p, string s, int start, int end)
        {
            if(start == end)
            {
                p.Add(s);
            }
            else
            {
                for(int i = start; i <= end; i++)
                {
                    s = swapAt(s, start, i);
                    permute(p, s, start + 1, end);
                    s = swapAt(s, start, i);
                }
            }
            return p;

        }
        static string swapAt(string s, int a, int b)
        {
            if (a >= s.Length || b >= s.Length)
            {
                return s;
            }
            else
            {
                char temp;
                char[] arr = s.ToCharArray();
                temp = arr[a];
                arr[a] = arr[b];
                arr[b] = temp;
                return new string(arr);
            }
        }
        static void Main(string[] args)
        {
            List<string> p = new List<string>();
            string s = Console.ReadLine();
            int si = int.Parse(s);
            int sj=-666;
            permute(p, s, 0, s.Length - 1);
            List<int> li = new List<int>();
            p.ForEach(x => li.Add(int.Parse(x)));
            li.Sort();
            for(int i = 0; i < li.Count; i++)
            {
                if (li[i] > si)
                {
                    sj = li[i];
                    break;
                }
            }
            if (sj == -666)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(sj);
            }
        }
    }
}
