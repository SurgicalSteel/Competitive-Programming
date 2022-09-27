using System;

namespace Event_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr;
            sarr = Console.ReadLine().Split(' ');
            int np = int.Parse(sarr[0]);
            int bud = int.Parse(sarr[1]);
            int nho = int.Parse(sarr[2]);
            int nwe = int.Parse(sarr[3]);
            int cpt,mini=int.MaxValue, cpn;
            for(int i = 0; i < nho; i++)
            {
                cpn = int.Parse(Console.ReadLine());
                sarr = Console.ReadLine().Split(' ');
                for(int x = 0; x < sarr.Length; x++) 
                {
                    if (int.Parse(sarr[x]) >= np && (np*cpn <= bud)) { mini = Math.Min(mini, np * cpn); break; }
                }
            }
            if (mini == int.MaxValue) { Console.WriteLine("stay home"); } else { Console.WriteLine(mini); }
        }
    }
}
