using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot_Hike
{
    class Program
    {

        struct hikeData
        {
            public int idx;
            public int toTemp;
            public int fromTemp;
            public int maxTemp;

            public hikeData(int idx, int toTemp, int fromTemp, int maxTemp)
            {
                this.idx = idx;
                this.toTemp = toTemp;
                this.fromTemp = fromTemp;
                this.maxTemp = maxTemp;
            }
        }

        static void Main(string[] args)
        {
            List<hikeData> hikes = new List<hikeData>();
            int miniMaxTemp = int.MaxValue;
            int tMaxTemp;
            int n = int.Parse(Console.ReadLine());
            string[] sarr = Console.ReadLine().Split(" ");
            int[] temp = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                temp[i] = int.Parse(sarr[i]);
            }

            for(int i = 0; i < n - 2; i++)
            {
                tMaxTemp = Math.Max(temp[i], temp[i + 2]);
                miniMaxTemp = Math.Min(tMaxTemp, miniMaxTemp);
                hikes.Add(new hikeData(i,temp[i],temp[i+2], tMaxTemp));
            }
            List<hikeData> selectedOrdered = new List<hikeData>();
            selectedOrdered = (from x in hikes orderby x.idx ascending where x.maxTemp == miniMaxTemp select x).ToList();
            Console.WriteLine("{0} {1}",selectedOrdered[0].idx + 1, selectedOrdered[0].maxTemp);
        }
    }
}
