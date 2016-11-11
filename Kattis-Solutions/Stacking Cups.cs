using System;
using System.Collections.Generic;
using System.Linq;
public class Test
{
    struct cup{
        public cup(int di,string co)
        {
            this.c=co;
            this.d=di;
        }
        public string c;
        public int d;
        
    };
    public static void Main()
    {
        string ti;
        string[] ta;
        int ntc,test;
        ti = Console.ReadLine();
        int.TryParse(ti, out ntc);
        List<cup> lc = new List<cup>();        
        for(int it=0;it<ntc;it++)
        {
            ta = Console.ReadLine().Split();
            if(int.TryParse(ta[0], out test))
            {
                test/=2;
                lc.Add(new cup(test,ta[1]));
            }
            else
            {
                int.TryParse(ta[1],out test);
                lc.Add(new cup(test,ta[0]));
            }
        }
        List<cup> sorted = (from x in lc orderby x.d select x).ToList<>();
        foreach(cup xc in sorted)
        {
            Console.WriteLine("{0}",xc.c);
        }
    }
}
