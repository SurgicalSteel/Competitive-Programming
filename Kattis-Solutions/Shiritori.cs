using System;
using System.Collections.Generic;

namespace Shiritori
{
    class Program
    {
        static void Main(string[] args)
        {
            int nw = int.Parse(Console.ReadLine());
            Dictionary<string, int> d = new Dictionary<string, int>();
            List<string> l = new List<string>();
            string curr="", last="";
            int pointLost = -1;
            for (int i = 0; i < nw; i++) {
                curr = Console.ReadLine();
                if (d.ContainsKey(curr))
                {     
                    if (pointLost < 0)
                    {
                       pointLost = (i % 2) + 1;
                    } 
                }else
                {
                    d.Add(curr,1);
                }
                if (i > 0)
                {
                    if (curr.Substring(0, 1) != last.Substring(last.Length - 1, 1)) {
                        if (pointLost < 0)
                        {
                            pointLost = (i % 2) + 1;
                        }
                    }
                }
                last = curr;
            }
            if(pointLost < 0)
            {
                Console.WriteLine("Fair Game");
            }
            else
            {
                Console.WriteLine("Player {0} lost", pointLost);
            }
        }
    }
}
