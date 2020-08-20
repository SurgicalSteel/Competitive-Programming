using System;

namespace Mirror_Images
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r, c;
            string tl;
            for(int tci = 0; tci < n; tci++)
            {
                string[] arr = Console.ReadLine().Split(" ");
                r = int.Parse(arr[0]);
                c = int.Parse(arr[1]);
                string[][] m = new string[r][];
                for(int i = 0; i < r; i++)
                {
                    m[i] = new string[c];
                    tl = Console.ReadLine();
                    for(int x = 0; x < tl.Length; x++)
                    {
                        m[i][x] = tl.Substring(x, 1);
                    }
                }
                Console.WriteLine("Test {0}", tci + 1);
                for(int j = r - 1; j >= 0; j--)
                {
                    for(int i = c - 1; i >= 0; i--)
                    {
                        Console.Write(m[j][i]);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}

