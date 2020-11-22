using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = Console.ReadLine();
            int x = (g.Length - 2) * 2;
            string n = "h";
            for(int i = 0; i < x; i++) { n += "e"; }
            n += "y";
            Console.WriteLine(n);
        }
    }
}
