using System;
using System.Collections.Generic;

namespace Count_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, szq, lastidx, evencnt =0, rescnt = 0, first;
            string[] sarr;
            int[] arr;
            sarr = Console.ReadLine().Split(' ');
            n = int.Parse(sarr[0]);
            szq = int.Parse(sarr[1]);
            lastidx = szq;
            sarr = Console.ReadLine().Split(' ');
            arr = new int[n];
            for(int i = 0; i < n; i++) { arr[i] = int.Parse(sarr[i]); }
            Queue<int> q = new Queue<int>();
            for(int i = 0; i < szq; i++) 
            { 
                if (arr[i] % 2 == 0) { evencnt++; } 
                q.Enqueue(arr[i]); 
            }
            if(evencnt >= 2) { rescnt++; }
            
            for(int x=lastidx; x < n; x++)
            {
                if (arr[x] % 2 == 0) { evencnt++; }
                q.Enqueue(arr[x]);
                first = q.Dequeue();
                if(first%2 == 0) { evencnt--; }
                if(evencnt >= 2) { rescnt++; }
            }
            Console.WriteLine(rescnt);
        }
    }
}
