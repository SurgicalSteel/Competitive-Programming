using System;
using System.Collections.Generic;
using System.Linq;

namespace Busy_Schedule
{
    class Program
    {
        struct TimeMarker
        {
            public TimeMarker(string print)
            {
                this.print = print;
                string[] vhmz = print.Split(" ");
                string sz = vhmz[1];
                string[] vhm = vhmz[0].Split(":");
                string sh = vhm[0];
                string sm = vhm[1];
                this.vm = int.Parse(sm);
                this.vh = 0;

                if (sz == "a.m.")
                {
                    this.vh = int.Parse(sh);
                }
                else if (sz == "p.m.")
                {
                    this.vh = int.Parse(sh) + 12;
                }
                
                if (sz=="a.m." && sh == "12")
                {
                    this.vh = 0;
                }else if(sz=="p.m." && sh == "12")
                {
                    this.vh = 12;
                }
                

            }
            public int vh;
            public int vm;
            public string print;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string tmpPrint;
            while (n > 0)
            {
                List<TimeMarker> timeMarkers = new List<TimeMarker>();
                for(int i = 0; i < n; i++)
                {
                    tmpPrint = Console.ReadLine();
                    timeMarkers.Add(new TimeMarker(tmpPrint));
                }
                List<TimeMarker> sorted = (from x in timeMarkers orderby x.vh, x.vm select x).ToList();
                for (int i = 0; i < n; i++)
                {
                    //Console.WriteLine(sorted[i].vh +"\t" + sorted[i].vm + "\t"+ sorted[i].print);
                    Console.WriteLine(sorted[i].print);
                }
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
