using System;

namespace Provinces_and_Gold
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cards = Console.ReadLine().Split(" ");
            int gold = int.Parse(cards[0]);
            int silver = int.Parse(cards[1]);
            int copper = int.Parse(cards[2]);

            int tot = (gold * 3) + (silver * 2) + (copper * 1);
            string a = "", b = "";
            if (tot >= 8) { a = "Province"; } else if(tot>=5){ a = "Duchy"; } else if (tot >= 2) { a = "Estate"; }
            if (tot >= 6) { b = "Gold"; } else if (tot >= 3) { b = "Silver"; } else if (tot >= 0) { b = "Copper"; }
            if (a.Length == 0) { Console.WriteLine(b); } else { Console.WriteLine("{0} or {1}",a,b); }
        }
    }
}
