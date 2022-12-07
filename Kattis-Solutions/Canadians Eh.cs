using System;

namespace Canadians_Eh
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(s.EndsWith("eh?") ? "Canadian!" : "Imposter!");
        }
    }
}
