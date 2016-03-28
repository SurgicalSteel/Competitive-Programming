using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot
{
    class Program
    {
        static int pangkat(int nb, int np)
        {
            if (np == 0) { return 1; }
            else { return nb * pangkat(nb, np - 1); }
        }
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            int total = 0;
            for (int x = 0; x < tc; ++x)
            {
                string temp = Console.ReadLine();
                int nbase = int.Parse(temp.Substring(0, temp.Length - 1));
                int npow = int.Parse(temp.Substring(temp.Length - 1, 1));
                total += pangkat(nbase, npow);
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
