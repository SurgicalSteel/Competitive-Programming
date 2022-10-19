using System;

namespace Test_Drive
{
    class Program
    {
        static void Main(string[] args)
        {
            int ma, mb, mc;
            string[] sarr = Console.ReadLine().Split(' ');
            ma = int.Parse(sarr[0]);
            mb = int.Parse(sarr[1]);
            mc = int.Parse(sarr[2]);
            if ((mc-mb) == (mb - ma)) { Console.WriteLine("cruised"); }else
            if ((mb>ma&&mb>mc) || (mb<ma&&mb<mc)) { Console.WriteLine("turned"); }else
            if (Math.Abs(mc-mb) < Math.Abs(mb-ma)) { Console.WriteLine("braked"); } else
            if (Math.Abs(mc - mb) > Math.Abs(mb - ma)) { Console.WriteLine("accelerated"); }
        }
    }
}
