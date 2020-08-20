using System;

namespace Cooking_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int minEnd = int.MaxValue, maxStart = int.MinValue;
            String s;
            int[] arrStart = new int[n];
            int[] arrEnd = new int[n];
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                String[] arr = s.Split(" ");
                arrStart[i] = int.Parse(arr[0]);
                arrEnd[i] = int.Parse(arr[1]);
            }
            bool edward = false;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(arrStart[i] > arrEnd[j] && i != j)
                    {
                        edward = true;
                    }
                }
            }
            if (edward)
            {
                Console.WriteLine("edward is right");
            }
            else
            {
                Console.WriteLine("gunilla has a point");
            }
        }
    }
}
