using System;
using System.Collections.Generic;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int num = int.Parse(Console.ReadLine());
            List<int> li = new List<int>();
            for(int i = 0; i < arr.Length; i++) { li.Add(int.Parse(arr[i])); }
            string[] grade = new string[]{ "A", "B", "C", "D", "E"};
            int x = 0;
            bool found = false;
            string res = "";

            while (!found && x < li.Count)
            {
                if (num >= li[x])
                {
                    found = true;
                    res = grade[x];
                }
                x++;
            }

            if (!found)
            {
                res = "F";

            }

            Console.WriteLine(res);

        }
    }
}
