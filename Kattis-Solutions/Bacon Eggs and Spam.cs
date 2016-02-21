using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacon_Eggs_and_Spam
{
    public class Program
    {
        public struct mapfp
        {
            public mapfp(string f, string p)
            {
                this.food = f;
                this.person = p;
            }
            public string food;
            public string person;
        };
        static void Main(string[] args)
        {
            int nread = int.Parse(Console.ReadLine());
            while(nread>0)
            {
                //start epoch
                List<mapfp> map = new List<mapfp>();
                for(int i=0;i<nread;i++)
                {
                    string[] inp = Console.ReadLine().Split();
                    for(int x=1;x<inp.Length;x++)
                    {map.Add(new mapfp(inp[x], inp[0]));}
                }
                var hashf = (from x in map orderby x.food select x.food).Distinct();
                List<string> fhash = new List<string>();
                fhash = hashf.ToList();
                for(int x=0;x<fhash.Count;x++)
                {
                    var vres = from item in map orderby item.person where item.food == fhash[x] select item.person;
                    List<string> cons = new List<string>();
                    cons = vres.ToList();
                    Console.Write("{0} ", fhash[x]);
                    for(int iter=0;iter<cons.Count;iter++)
                    {
                        if (iter + 1 == cons.Count) { Console.Write("{0}\n", cons[iter]); }
                        else { Console.Write("{0} ", cons[iter]); }
                    }
                }
                //end epoch
                nread = int.Parse(Console.ReadLine());
                if(nread>0){Console.WriteLine();}
            }
            //Console.ReadLine();
        }
    }
}
