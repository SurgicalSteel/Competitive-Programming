using System;
using System.Collections.Generic;

namespace Relocation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr;
            int[] initLocation;
            int nc, nq, cmd, tempc, ca, cb, tempLoc,la,lb;

            sarr = Console.ReadLine().Split(" ");
            nc = int.Parse(sarr[0]);
            nq = int.Parse(sarr[1]);
            sarr = Console.ReadLine().Split(" ");
            initLocation = new int[sarr.Length];
            Dictionary<int, int> locData = new Dictionary<int, int>();
            for(int i = 0; i < sarr.Length; i++)
            {
                initLocation[i] = int.Parse(sarr[i]);
                locData[i + 1] = int.Parse(sarr[i]);
            }
            for(int i=0;i< nq; i++)
            {
                sarr = Console.ReadLine().Split(" ");
                if (sarr[0] == "1")
                {
                    tempc = int.Parse(sarr[1]);
                    tempLoc = int.Parse(sarr[2]);
                    locData.Remove(tempc);
                    locData.Add(tempc, tempLoc);
                }else if (sarr[0] == "2")
                {
                    ca = int.Parse(sarr[1]);
                    cb = int.Parse(sarr[2]);
                    la = locData[ca];
                    lb = locData[cb];
                    Console.WriteLine("{0}", Math.Abs(la - lb));
                }
            }
        }
    }
}
