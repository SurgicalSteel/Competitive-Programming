using System;

namespace Piece_of_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, pa, pb, maxl = 0;
            String[] arr = Console.ReadLine().Split(" ");
            s = int.Parse(arr[0]);
            pa = int.Parse(arr[1]);
            pb = int.Parse(arr[2]);

            int cay = pa * (s - pb);
            int cab = pa * pb;
            int cxb = (s - pa) * pb;
            int cxy = (s - pa) * (s - pb);

            maxl = Math.Max(Math.Max(cay, cab), Math.Max(cxb, cxy));
            Console.WriteLine("{0}", maxl * 4);
        }
    }
}

