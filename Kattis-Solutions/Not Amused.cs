using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Not_Amused_Kattis
{
    class MainClass
    {
        public struct person
        {
            public person(string nm, double pr, int cm)
            {this.name=nm;this.price=pr;this.currminute=cm;}
            public string name;public double price;public int currminute;};
        public static void Main(string[] args)
        {
            person tempperson;
            int day=0;
            string statpark = Console.ReadLine();
            while (!string.IsNullOrEmpty(statpark))
            {
                //initialize hash
                List<person> lp=new List<person>();
                while (!statpark.Equals("CLOSE"))
                {
                    if (statpark.Equals("OPEN"))//next
                    {
                        statpark = Console.ReadLine();day++;
                    }
                    string[] tempsplit = statpark.Split();
                    if (tempsplit[0].Equals("ENTER"))
                    {
                        if (lp.Exists(item => item.name == tempsplit[1]))
                        {
                            int idx = lp.FindIndex(item => item.name == tempsplit[1]);
                            int min=int.Parse(tempsplit[2]);
                            string nma=lp[idx].name;
                            double pri=lp[idx].price;
                            lp[idx] = new person(nma,pri,min);
                        }
                        else
                        {
                            tempperson.currminute = int.Parse(tempsplit[2]);
                            tempperson.name = tempsplit[1];
                            tempperson.price = 0;
                            lp.Add(tempperson);
                        }
                    }
                    else //EXIT
                    {
                        int idx = lp.FindIndex(item => item.name == tempsplit[1]);
                        int myminutes=int.Parse(tempsplit[2]);
                        string nama=lp[idx].name;
                        double harga=lp[idx].price+((myminutes-lp[idx].currminute)*0.1);
                        int menitsekarang=lp[idx].currminute;
                        lp[idx]=new person(nama,harga,menitsekarang);
                    }
                    statpark = Console.ReadLine();
                }
                //output
                var tempc=from x in lp orderby x.name select x;
                lp = tempc.ToList();
                Console.WriteLine("Day {0}",day);
                foreach (person prs in lp)
                {
                    Console.WriteLine(String.Format("{0} ${1:F2}", prs.name, prs.price));
                }
                Console.WriteLine();
                //clear hash
                lp=new List<person>();
                statpark = Console.ReadLine();
            }
        }
    }
}
