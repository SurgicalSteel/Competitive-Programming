using System;
using System.Collections.Generic;
using System.Linq;

namespace Best_Relay_Team
{
    class Program
    {
        struct Runner
        {
            public Runner(string name, double first, double second)
            {
                this.name = name;
                this.first = first;
                this.second = second;
            }
            public string name;
            public double first;
            public double second;

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double mini = double.MaxValue;
            double tmp;
            string a="", b="",c="", d="";
            String[] arr;
            List<Runner> runners = new List<Runner>();
            Runner first;
            for(int i = 0; i < n; i++)
            {
                arr = Console.ReadLine().Split(" ");
                runners.Add(new Runner(arr[0], double.Parse(arr[1]), double.Parse(arr[2])));
            }

            for(int i = 0; i < runners.Count; i++)
            {
                first = runners[i];
                List<Runner> topThreeOnSecondWithoutFirst = new List<Runner>();
                topThreeOnSecondWithoutFirst = (from r in runners orderby r.second ascending where r.name != first.name select r).ToList();
                tmp = first.first + topThreeOnSecondWithoutFirst[0].second + topThreeOnSecondWithoutFirst[1].second + topThreeOnSecondWithoutFirst[2].second;
                if (tmp == Math.Min(tmp, mini))
                {
                    mini = tmp;
                    a = first.name;
                    b = topThreeOnSecondWithoutFirst[0].name;
                    c = topThreeOnSecondWithoutFirst[1].name;
                    d = topThreeOnSecondWithoutFirst[2].name;
                }
            }
            Console.WriteLine("{0:F9}", mini);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
