using System;

namespace Coffee_Cup_Combo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++){ arr[i] = 0; }
            int temp;
            for (int i = 0; i < n; i++)
            {
                temp = int.Parse(s.Substring(i, 1));
                if (temp == 1)
                {
                    arr[i] = temp;
                    if (i + 1 < n) { arr[i + 1] = temp; }
                    if (i + 2 < n) { arr[i + 2] = temp; }
                }
            }

            int nc = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0) { nc++; }
            }
            Console.WriteLine(nc);
        }
    }
}
