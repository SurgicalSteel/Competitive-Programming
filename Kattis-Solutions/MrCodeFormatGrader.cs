using System;
using System.Collections.Generic;

namespace MrCodeFormatGrader
{
    class Segment
    {
        public Segment()
        {
            max = -1;
            range = new List<int>();
        }

        public int max { get; set; }
        public int min { get; set; }
        private List<int> range;

        public bool check(int a)
        {
            return max + 1 == a;
        }

        public void addNumber(int a) 
        {
            range.Add(a);
            max = a;
            min = range[0];
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] tempArr;
            int nc, n, ne, x;
            bool found;
            Segment s;

            tempArr = Console.ReadLine().Split(' ');
            n = int.Parse(tempArr[0]);
            ne = int.Parse(tempArr[1]);
            List<int> lc = new List<int>();
            List<int> le = new List<int>();

            tempArr = Console.ReadLine().Split(' ');
            for(int i = 0; i < tempArr.Length; i++) { le.Add(int.Parse(tempArr[i])); }
            for(int i = 1; i <= n; i++) { if (!le.Contains(i)) { lc.Add(i); } }
            le.Sort();
            lc.Sort();

            List<Segment> lle = new List<Segment>();
            for(int i = 0; i < le.Count; i++)
            {
                if (lle.Count == 0)
                {
                    s = new Segment();
                    s.addNumber(le[i]);
                    lle.Add(s);
                }
                else
                {
                    found = false;
                    x = 0;
                    while(x<lle.Count && !found)
                    {
                        found = lle[x].check(le[i]);
                        if (found) { lle[x].addNumber(le[i]); }
                        x++;
                    }

                    if (!found){
                        s = new Segment();
                        s.addNumber(le[i]);
                        lle.Add(s);
                    }

                }
            }


            List<Segment> llc = new List<Segment>();
            for (int i = 0; i < lc.Count; i++)
            {
                if (llc.Count == 0)
                {
                    s = new Segment();
                    s.addNumber(lc[i]);
                    llc.Add(s);
                }
                else
                {
                    found = false;
                    x = 0;
                    while (x < llc.Count && !found)
                    {
                        found = llc[x].check(lc[i]);
                        if (found) { llc[x].addNumber(lc[i]); }
                        x++;
                    }

                    if (!found)
                    {
                        s = new Segment();
                        s.addNumber(lc[i]);
                        llc.Add(s);
                    }

                }
            }

            lle.Sort((fuck, off) => fuck.min.CompareTo(off.min));
            llc.Sort((fuck, off) => fuck.min.CompareTo(off.min));

            string se = "Errors: ";
            for(int i = 0; i < lle.Count; i++)
            {
                if(i+1 == lle.Count) { se += "and "; }
                if(lle[i].min == lle[i].max) 
                {
                    if (i + 1 == lle.Count)
                    {
                        se += String.Format("{0}", lle[i].min);
                    }
                    else if (i + 2 == lle.Count)
                    {
                        se += String.Format("{0} ", lle[i].min);
                    }
                    else 
                    {
                        se += String.Format("{0}, ", lle[i].min);
                    }
                         
                } 
                else 
                {
                    if (i + 1 == lle.Count)
                    {
                        se += String.Format("{0}-{1}", lle[i].min, lle[i].max);
                    }
                    else if (i + 2 == lle.Count)
                    {
                        se += String.Format("{0}-{1} ", lle[i].min, lle[i].max);
                    }
                    else 
                    {
                        se += String.Format("{0}-{1}, ", lle[i].min, lle[i].max);
                    }
                }
            }

            string sc = "Correct: ";
            for (int i = 0; i < llc.Count; i++)
            {
                if (i + 1 == llc.Count) { sc += "and "; }
                if (llc[i].min == llc[i].max)
                {
                    if (i + 1 == llc.Count)
                    {
                        sc += String.Format("{0}", llc[i].min);
                    }
                    else if (i + 2 == llc.Count)
                    {
                        sc += String.Format("{0} ", llc[i].min);
                    }
                    else
                    {
                        sc += String.Format("{0}, ", llc[i].min);
                    }
                        
                }
                else
                {
                    if (i + 1 == llc.Count)
                    {
                        sc += String.Format("{0}-{1}", llc[i].min, llc[i].max);
                    }
                    else if (i + 2 == llc.Count)
                    {
                        sc += String.Format("{0}-{1} ", llc[i].min, llc[i].max);
                    }
                    else
                    {
                        sc += String.Format("{0}-{1}, ", llc[i].min, llc[i].max);
                    }
                }
            }

            Console.WriteLine(se);
            Console.WriteLine(sc);

        }
    }
}
