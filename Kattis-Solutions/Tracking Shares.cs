using System;
using System.Collections.Generic;
using System.Linq;

namespace Tracking_Shares
{
    class CompanyShare
    {
        private List<int> _days;
        private Dictionary<int, int> _dayShareMap;

        public CompanyShare(List<string> ls)
        {
            List<int> tmpDays = new List<int>();
            Dictionary<int, int> tmpDSM = new Dictionary<int, int>();
            string[] sarr;
            for(int i = 0; i < ls.Count; i++) 
            {
                sarr = ls[i].Split();
                tmpDays.Add(int.Parse(sarr[1]));
                tmpDSM.Add(int.Parse(sarr[1]), int.Parse(sarr[0]));
            }
            _days = tmpDays;
            _dayShareMap = tmpDSM;
        }
        public int GetShareOnDay(int d) 
        {
            int share = 0;
            List<int> res = (from x in _days where x <= d select x).ToList();
            if(res.Count == 0) { return share; }
            share = _dayShareMap[res.Max()];
            return share;
        }
        public List<int> GetDays() { return _days; }
    }

    class Program
    {
        static List<int> getAllUniqueDays(List<CompanyShare> csl) 
        {
            List<int> raw = new List<int>();
            foreach(CompanyShare cs in csl)
            {
                raw.AddRange(cs.GetDays());
            }
            raw = raw.Distinct().OrderBy(x => x).ToList();
            return raw;
        }

        static void printList(List<int> l) 
        {
            string s = "";
            for(int i = 0; i < l.Count; i++) { s+= (l[i].ToString() + " "); }
            Console.WriteLine(s);
        }

        static int getTotalSharesOnDay(List<CompanyShare> csl, int day) 
        {
            int tot = 0;

            foreach(CompanyShare cs in csl) { tot += cs.GetShareOnDay(day); }

            return tot;
        }

        static void Main(string[] args)
        {
            int nc = int.Parse(Console.ReadLine());
            //HashSet<int> uniqueDays = new HashSet<int>();
            List<string> tmpComp;
            List<CompanyShare> csl = new List<CompanyShare>();
            int tnd;
            for (int x = 0; x < nc; x++) 
            {
                tnd = int.Parse(Console.ReadLine());
                tmpComp = new List<string>();
                for(int y = 0; y < tnd; y++) 
                {
                    tmpComp.Add(Console.ReadLine());
                }
                csl.Add(new CompanyShare(tmpComp));
            }

            List<int> uniDays = getAllUniqueDays(csl);
            List<int> shareSorted = new List<int>();
            for(int x = 0; x < uniDays.Count; x++) 
            {
                shareSorted.Add(getTotalSharesOnDay(csl, uniDays[x]));
            }

            string s = "";
            for(int x = 0; x < shareSorted.Count; x++) 
            {
                if (x == 0) { s += shareSorted[x].ToString(); } else { s += (" " + shareSorted[x].ToString()); }
            }

            Console.WriteLine(s);
        }
    }
}

