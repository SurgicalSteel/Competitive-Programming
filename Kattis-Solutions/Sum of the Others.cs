using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_the_Others
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            while (!string.IsNullOrEmpty(inp))
            {
                List<string> lstr = inp.Split().ToList<string>();
                List<int> lint = new List<int>();
                int sum = 0;
                for (int i = 0; i < lstr.Count; ++i)
                { lint.Add(int.Parse(lstr[i])); sum += int.Parse(lstr[i]); }
                int x=0;
                bool breaker = false;
                while(x < lint.Count&&!breaker)
                {
                    if (sum - lint[x] == lint[x]) { Console.WriteLine(lint[x]); breaker = true; }
                    x++;
                }
                inp = Console.ReadLine();
            }
        }
    }
}
