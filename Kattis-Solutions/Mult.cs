using System;
using System.Collections.Generic;

namespace Mult
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> li = new List<int>(n);

            int t,startNum, startPos, currPos;
            for(int i = 0; i < n; i++) { li.Add(int.Parse(Console.ReadLine())); }
            
            List<int> res = new List<int>();
            startPos = 0;
            currPos = 0;

            while(currPos < li.Count)
            {
                if(currPos == startPos) { currPos++; } else
                {
                    if (li[currPos] % li[startPos] == 0)
                    {
                        res.Add(li[currPos]);
                        startPos = currPos + 1;
                        currPos = startPos;
                    }
                    else
                    {
                        currPos++;
                    }
                }
            }

            for(int i = 0; i < res.Count; i++) { Console.WriteLine(res[i]); }

        }
    }
}
