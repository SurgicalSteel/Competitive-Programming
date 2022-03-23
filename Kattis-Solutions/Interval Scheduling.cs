using System;
using System.Collections.Generic;

namespace Interval_Scheduling
{
    class Program
    {
        class Interval
        {
            public Interval(int s, int e) 
            {
                this.start = s;
                this.end = e;
                this.duration = e - s;
            }
            public int start { get; set; }
            public int end { get; set; }
            public int duration { get; set; }
        }
        static void Main(string[] args)
        {
            int ni = int.Parse(Console.ReadLine());
            string[] sarr;
            int ts, te;
            List<Interval> li = new List<Interval>();
            for(int i = 0; i < ni; i++) 
            {
                sarr = Console.ReadLine().Split(' ');
                ts = int.Parse(sarr[0]);
                te = int.Parse(sarr[1]);
                li.Add(new Interval(ts, te));
            }

            li.Sort((x, y) => x.end.CompareTo(y.end));
            List<Interval> selected = new List<Interval>();
            int let=0;
            for(int i = 0; i < li.Count; i++) 
            {
                if (i == 0 || (li[i].start >= let))
                {
                    selected.Add(li[i]);
                    let = li[i].end;
                }
            }

            Console.WriteLine(selected.Count);

        }
    }
}
