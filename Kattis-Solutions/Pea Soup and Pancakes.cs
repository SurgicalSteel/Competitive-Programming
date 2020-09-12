using System;
using System.Collections.Generic;

namespace Pea_Soup_and_Pancakes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> restaurants = new List<string>();
            int tc = int.Parse(Console.ReadLine());
            int nm;
            string temprest,tempmen;
            bool hps, hp;
            for(int x = 0; x < tc; x++)
            {
                hps = false;
                hp = false;
                nm = int.Parse(Console.ReadLine());
                temprest = Console.ReadLine();
                for(int j = 0; j < nm; j++)
                {
                    tempmen = Console.ReadLine();
                    if(tempmen.Equals("pea soup")) { hps = true; }
                    if(tempmen.Equals("pancakes")) { hp = true; }
                }
                if (hp && hps) { restaurants.Add(temprest); }
            }
            if (restaurants.Count > 0)
            {
                Console.WriteLine(restaurants[0]);
            }
            else
            {
                Console.WriteLine("Anywhere is fine I guess");
            }
        }
    }
}
