using System;

namespace Fifty_Shades_of_Pink
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            string s;
            for(int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                s = s.ToLower();
                if(s.Contains("rose") || s.Contains("pink"))
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("I must watch Star Wars with my daughter");
            }
            else
            {
                Console.WriteLine("{0}", counter);
            }
        }
    }
}
