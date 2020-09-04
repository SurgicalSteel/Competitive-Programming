using System;

namespace Chanukah_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                String[] arr = Console.ReadLine().Split(" ");
                int num = int.Parse(arr[1]);
                int res = ((num + 1) * num) / 2 + num;
                Console.WriteLine("{0} {1}", arr[0], res);
            }
        }
    }
}
