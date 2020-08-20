using System;
using System.Collections.Generic;

namespace Saving_Princess_Peach
{
    class Program
    {
        static void Main(string[] args)
        {
            int nob, ncmar,tcmar;
            String s = Console.ReadLine();
            String[] arr = s.Split(" ");
            nob = int.Parse(arr[0]);
            ncmar = int.Parse(arr[1]);
            Dictionary<int, int> d = new Dictionary<int, int>();
            for(int i = 0; i < ncmar; i++)
            {
                tcmar = int.Parse(Console.ReadLine());
                if (!d.ContainsKey(tcmar))
                {
                    d.Add(tcmar, 1);
                }
            }
            for(int i = 0; i < nob; i++)
            {
                if (d.ContainsKey(i)) { continue; }
                else { Console.WriteLine(i); }
            }
            Console.WriteLine("Mario got {0} of the dangerous obstacles.", d.Count);
        }
    }
}
