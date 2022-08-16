using System;
using System.Collections.Generic;
using System.Linq;
namespace Open_Source
{
    class Program
    {
        static bool checkUpper(string s)
        {
            return Char.IsUpper(s[0]);
        }
        static bool isExist(List<string> l, string s) { return l.Contains(s); }

        struct summary
        {
            public string name;
            public int count;
            public summary(string n, int c)
            {
                this.name = n;
                this.count = c;
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            List<string> osp;
            List<string> rawstu, dupstu;
            Dictionary<string, List<string>> dm;
            Dictionary<string, string> dsosp;
            List<summary> lsum;
            bool breaker = false;
            string currosp = "";
            int currospidx;
            lsum = new List<summary>();
            osp = new List<string>();
            rawstu = new List<string>();
            dupstu = new List<string>();
            dsosp = new Dictionary<string, string>();
            dm = new Dictionary<string, List<string>>();
            breaker = false;
            while (true)
            {
                if (s.Equals("0")) { break; }
                else
                {
                    if (s.Equals("1"))
                    {
                        for (int x = 0; x < osp.Count; x++)
                        {
                            rawstu = dm[osp[x]];
                            for (int y = 0; y < dupstu.Count; y++)
                            {
                                if (rawstu.Contains(dupstu[y]))
                                {
                                    rawstu.RemoveAt(rawstu.IndexOf(dupstu[y]));
                                }
                            }
                            dm[osp[x]] = rawstu;
                        }

                        for (int x = 0; x < osp.Count; x++)
                        {
                            rawstu = dm[osp[x]];
                            lsum.Add(new summary(osp[x], rawstu.Count));
                        }

                        lsum = (from fuck in lsum orderby fuck.count descending, fuck.name ascending select fuck).ToList();
                        for (int i = 0; i < lsum.Count; i++)
                        {
                            Console.WriteLine("{0} {1}", lsum[i].name, lsum[i].count);
                        }
                        breaker = true;
                        lsum = new List<summary>();
                        osp = new List<string>();
                        rawstu = new List<string>();
                        dupstu = new List<string>();
                        dsosp = new Dictionary<string, string>();
                        dm = new Dictionary<string, List<string>>();
                        breaker = false;
                    }
                    else
                    {
                        if (checkUpper(s))
                        {
                            osp.Add(s);
                            if (!dm.ContainsKey(s)) { dm.Add(s, new List<string>()); }
                            currosp = s;
                        }
                        else
                        {
                            //Console.WriteLine("debug " + s);
                            if (dsosp.ContainsKey(s))
                            {
                                if (!dsosp[s].Equals(currosp))
                                {
                                    dupstu.Add(s);
                                }
                            }
                            else { dsosp.Add(s, currosp); }
                            rawstu = dm[currosp];
                            if (!rawstu.Contains(s)) { rawstu.Add(s); dm.Remove(currosp); dm.Add(currosp, rawstu); }
                        }
                    }
                }
                s = Console.ReadLine();
            }
        }
    }
}
