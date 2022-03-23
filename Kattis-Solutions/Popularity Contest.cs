using System;

namespace Popularity_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(' ');
            int[] people = new int[int.Parse(sarr[0])];
            int n = int.Parse(sarr[1]);
            int a, b;
            for (int i = 0; i < n; i++)
            {
                sarr = Console.ReadLine().Split(' ');
                a = int.Parse(sarr[0]);
                b = int.Parse(sarr[1]);

                people[a - 1] = people[a - 1] + 1;
                people[b - 1] = people[b - 1] + 1;
            }
            int[] final = new int[people.Length];
            string result = "";
            for(int i = 0; i < people.Length; i++)
            {
                final[i] = people[i] - (i + 1);
                if (i + 1 == people.Length)
                {
                    result += string.Format("{0}", final[i]);
                }
                else
                {
                    result += string.Format("{0} ", final[i]);
                }
            }

            Console.WriteLine(result);

        }
    }
}
