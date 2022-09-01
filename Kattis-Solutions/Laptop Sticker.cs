using System;

namespace Laptop_Sticker
{
    class Program
    {
        static void Main(string[] args)
        {
            int wc, hc, ws, hs;
            string[] sarr = Console.ReadLine().Split(' ');
            wc = int.Parse(sarr[0]);
            hc = int.Parse(sarr[1]);
            ws = int.Parse(sarr[2]);
            hs = int.Parse(sarr[3]);
            if (wc - ws >= 2 && hc - hs >= 2) { Console.WriteLine("1"); } else { Console.WriteLine("0"); }
        }
    }
}
