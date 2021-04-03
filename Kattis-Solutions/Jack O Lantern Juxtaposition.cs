using System;

namespace Jack_O_Lantern_Juxtaposition
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(" ");
            int tot = int.Parse(sarr[0]) * int.Parse(sarr[1]) * int.Parse(sarr[2]);
            Console.WriteLine("{0}", tot);
        }
    }
}
