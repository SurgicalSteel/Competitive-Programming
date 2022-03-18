using System;

namespace Eye_of_Sauron
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s.Length % 2 == 1)
            {
                Console.WriteLine("fix");
            }
            else
            {
                bool ca, cb;
                int pos=-1;
                for(int i = 0; i < s.Length; i++)
                {
                    if (s.Substring(i, 1) == "(") { pos = i; break; }
                }

                if (pos+1 == s.Length / 2)
                {
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("fix");
                }
                
            }
        }
    }
}
