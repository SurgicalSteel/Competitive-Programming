using System;

namespace Climbing_Worm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(" ");
            int p = int.Parse(sarr[0]);
            int m = int.Parse(sarr[1]);
            int h = int.Parse(sarr[2]);

            int count = 0,currHeight=0;
            while (currHeight < h)
            {
                currHeight += p;
                if(currHeight>= h)
                {
                    count++;
                    break;
                }
                currHeight -= m;
                count++;
            }

            Console.WriteLine("{0}", count);
        }
    }
}
