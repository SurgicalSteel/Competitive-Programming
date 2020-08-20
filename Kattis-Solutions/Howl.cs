using System;

namespace Howl
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            if (s.Substring(s.Length - 1, 1) == "W")
            {
                s += "H";
            }
            else if (s.Substring(s.Length - 1, 1) == "O")
            {
                s += "W";
            }
            else if (s.Substring(s.Length - 1, 1) == "H")
            {
                s += "O";
            }
            Console.WriteLine(s);
        }
    }
}
