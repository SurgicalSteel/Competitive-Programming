using System;

namespace Pokechat
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string idxs = Console.ReadLine();
            string build = "";
            int tmpidx;
            for(int i = 0; i < idxs.Length - 2; i += 3)
            {
                tmpidx = int.Parse(idxs.Substring(i, 3)) - 1;
                //Console.WriteLine(tmpidx);
                build += s.Substring(tmpidx, 1);
            }
            Console.WriteLine(build);
        }
    }
}
