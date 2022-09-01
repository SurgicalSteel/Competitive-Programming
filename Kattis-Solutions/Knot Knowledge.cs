using System;
using System.Collections.Generic;
namespace Knot_Knowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] sarra, sarrb;
            sarra = Console.ReadLine().Split(' ');
            sarrb = Console.ReadLine().Split(' ');

            bool found = false;
            for(int i = 0; i < sarra.Length; i++)
            {
                found = false;
                for (int j = 0; j < sarrb.Length; j++) { if (sarra[i] == sarrb[j]) { found = true; break; } }
                if (!found) { Console.WriteLine(sarra[i]); }
            }
        }
    }
}
