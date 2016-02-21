using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_Call_Kattis
{
    class Program
    {
        struct nametype
        {
            public nametype(string f, string l)
            {
                this.first = f;
                this.last = l;
            }
            public string first, last;
        };
        static bool isuniquefirst(List<nametype> src, string name)
        {
            int ctr = 0;
            for(int i=0;i<src.Count;i++)
            {
                if (src[i].first == name) { ctr++; }
            }
            return ctr==1;
        }
        static void Main(string[] args)
        {
            List<nametype> students = new List<nametype>();
            string name = Console.ReadLine();
            while (!string.IsNullOrEmpty(name))
            {
                string[] tempname = new string[2];
                tempname = name.Split();
                students.Add(new nametype(tempname[0], tempname[1]));
                name=Console.ReadLine();
            }
            List<nametype> cares = (from x in students orderby x.last,x.first select x).ToList();
            for(int i=0;i<cares.Count;i++)
            {
                if (isuniquefirst(cares, cares[i].first))
                {
                    Console.WriteLine("{0}",cares[i].first);
                }
                else
                {
                    Console.WriteLine("{0} {1}", cares[i].first, cares[i].last);
                }
            }
            //Console.ReadLine();
        }
    }
}
