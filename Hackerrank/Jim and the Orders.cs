using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jim_and_Orders_Hackerrank
{
    class Program
    {
        struct order
        {
            public order(int ke, int star, int du, int arriv)
            {
                this.ken = ke;
                this.start = star;
                this.dur = du;
                this.arrive = arriv;
            }
            public int ken, start, dur, arrive;
        };
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<order> ordcols = new List<order>(); 
            for (int i=0;i< n;i++)
            {
                string[] temparr = Console.ReadLine().Split();
                int arrv = int.Parse(temparr[0]), durr = int.Parse(temparr[1]);
                ordcols.Add(new order(i+1, arrv, durr, arrv + durr));
            }
            List < order > ordered= (from x in ordcols orderby x.arrive, x.ken select x).ToList<order>();
            for(int i = 0; i < ordered.Count; i++) { Console.Write("{0} ", ordered[i].ken); }
            Console.WriteLine();
        }
    }
}
