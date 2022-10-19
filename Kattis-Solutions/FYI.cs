using System;

namespace FYI
{
    class Program
    {
        static void Main(string[] args)
        {
            string telnum = Console.ReadLine();
            Console.WriteLine(telnum.StartsWith("555")? 1 : 0);
        }
    }
}
