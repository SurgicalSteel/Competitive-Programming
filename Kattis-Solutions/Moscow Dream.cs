using System;

namespace Moscow_Dream
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abcn = Console.ReadLine().Split(" ");
            int a = int.Parse(abcn[0]);
            int b = int.Parse(abcn[1]);
            int c = int.Parse(abcn[2]);
            int n = int.Parse(abcn[3]);

            if(a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("NO");
                return;
            }
            
            if(n<3){
                Console.WriteLine("NO");
                return;
            }

            if((a+b+c) >= n)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

