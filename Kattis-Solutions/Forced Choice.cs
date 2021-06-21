using System;

namespace Forced_Choice
{
    class Program
    {
        static void Main(string[] args)
        {
            int tot, pred, nq;
            string[] sarr = Console.ReadLine().Split();
            tot = int.Parse(sarr[0]);
            pred = int.Parse(sarr[1]);
            nq = int.Parse(sarr[2]);
            bool isKeep;
            for(int i = 0; i < nq; i++)
            {
                isKeep = false;
                sarr = Console.ReadLine().Split();
                for(int j = 1; j < sarr.Length; j++)
                {
                    if (int.Parse(sarr[j]) == pred) { isKeep = true; j = sarr.Length; }
                }
                if (isKeep) { Console.WriteLine("KEEP"); } else { Console.WriteLine("REMOVE"); }

            }
        }
    }
}

