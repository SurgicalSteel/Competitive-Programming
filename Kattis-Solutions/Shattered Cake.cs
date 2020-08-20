using System;

namespace Shattered_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int tempArea = 0;
            for(int i = 0; i < n; i++)
            {
                String[] arr = Console.ReadLine().Split(" ");
                tempArea += (int.Parse(arr[0]) * int.Parse(arr[1]));
            }
            Console.WriteLine(tempArea / w);
        }
    }
}
