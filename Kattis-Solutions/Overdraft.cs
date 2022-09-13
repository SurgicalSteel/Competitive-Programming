using System;

namespace Overdraft
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximin = int.MaxValue;
            int n = int.Parse(Console.ReadLine());
            int x, curr=0;
            for(int i = 0; i < n; i++) 
            {
                x = int.Parse(Console.ReadLine());
                if (i == 0) { curr = x; maximin = Math.Min(curr, maximin); } else 
                {
                    curr += x;
                    maximin = Math.Min(curr, maximin);
                }
            }
            if(maximin < 0) { Console.WriteLine(maximin * -1); } else { Console.WriteLine(0); }
        }
    }
}
