using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mod = new List<int>();
            int temp;
            for(int i = 0; i < 10; i++)
            {
                temp = int.Parse(Console.ReadLine());
                mod.Add(temp % 42);
            }
            List<int> ctr = mod.Distinct().ToList();
            Console.WriteLine(ctr.Count);
        }
    }
}
