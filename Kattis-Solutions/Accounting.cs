using System;
using System.Collections.Generic;

namespace Accounting
{
    class Program
    {
        static void Main(string[] args)
        {
            int np,nq,p,m;
            string action;
            string[] arr = Console.ReadLine().Split(" ");
            np = int.Parse(arr[0]);
            nq = int.Parse(arr[1]);
            Dictionary<int, int> d = new Dictionary<int, int>();
            int defaultV = 0;
            for(int i = 0; i < nq; i++)
            {
                arr = Console.ReadLine().Split(" ");
                switch (arr[0])
                {
                    case "SET":
                        p = int.Parse(arr[1]);
                        m = int.Parse(arr[2]);
                        if (d.ContainsKey(p))
                        {
                            d.Remove(p);
                        }
                        d.Add(p, m);
                        break;
                    case "PRINT":
                        p = int.Parse(arr[1]);
                        if (d.ContainsKey(p))
                        {
                            Console.WriteLine(d[p]);
                        }
                        else
                        {
                            Console.WriteLine(defaultV);
                        }
                        break;
                    case "RESTART":
                        m = int.Parse(arr[1]);
                        defaultV = m;
                        d.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
