using System;
using System.Linq;
using System.Collections.Generic;

namespace Lost_Lineup
{
    class Person
    {
        public int id { get; set; }
        public int space { get; set; }
        public Person(int i, int s) 
        {
            this.id = i;
            this.space = s;
        }
        public string getIDs()
        {
            return this.id.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int np = int.Parse(Console.ReadLine());
            if (np == 1) { Console.WriteLine(1); return;}
            string[] sarr = Console.ReadLine().Split(' ');
            List<Person> lp = new List<Person>();
            for (int x = 0; x < sarr.Length; x++) 
            {
                lp.Add(new Person(x + 2, int.Parse(sarr[x])));
            }
            List<Person> olp = (from sp in lp orderby sp.space select sp).ToList();
            string s = "1";
            for(int i = 0; i < olp.Count; i++) { s += ( " "  + olp[i].getIDs()); }
            Console.WriteLine(s);
        }
    }
}
