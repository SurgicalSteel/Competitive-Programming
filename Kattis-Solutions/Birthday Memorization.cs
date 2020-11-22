using System;
using System.Collections.Generic;
using System.Linq;
namespace Birthday_Memorization
{
    class Program
    {
        class Person
        {
            public string name;
            public string birthday;
            public int likeness;
            public Person(string name, string birthday, int likeness)
            {
                this.name = name;
                this.birthday = birthday;
                this.likeness = likeness;
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, List<Person>> dall = new Dictionary<string, List<Person>>();
            int n = int.Parse(Console.ReadLine());
            int maxi;
            string[] sarr;
            List<Person> templist;
            for(int i = 0; i < n; i++)
            {
                sarr = Console.ReadLine().Split(" ");
                if (!dall.ContainsKey(sarr[2]))
                {templist = new List<Person>();}
                else { templist = dall[sarr[2]]; }
                templist.Add(new Person(sarr[0], sarr[2], int.Parse(sarr[1])));
                dall.Remove(sarr[2]);
                dall.Add(sarr[2], templist);
            }
            List<Person> result = new List<Person>();
            foreach(var key in dall.Keys)
            {
                templist = dall[key];
                maxi = templist.Max(x => x.likeness);
                templist = (from x in templist where x.likeness.Equals(maxi) select x).ToList();
                result.Add(templist[0]);
            }
            result = result.OrderBy(x => x.name).ToList();
            Console.WriteLine(result.Count);
            for(int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].name);
            }
        }
    }
}
