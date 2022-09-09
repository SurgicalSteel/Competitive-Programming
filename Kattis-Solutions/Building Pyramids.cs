using System;

namespace Building_Pyramids
{
    class Program
    {
        static void Main(string[] args)
        {
            int nblock = int.Parse(Console.ReadLine());
            int height = 1;
            int currnum = 1;
            int tot = 1;
            while (true) 
            {
                int nextblock = (int)(Math.Pow(currnum + 2, 2));
                if ((tot + nextblock ) <= nblock) { height++; tot+= nextblock; currnum += 2; } else { break; }
            }
            Console.WriteLine(height);
        }
    }
}
