using System;

namespace Sticky_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string sin = Console.ReadLine();
            string cc = sin.Substring(0,1);
            string vs;
            string res = "";
            for(int i = 0; i < sin.Length; i++)
            {
                vs = sin.Substring(i, 1);
                if(vs != cc) { res += cc; cc = vs; }
                if ((i + 1) == sin.Length) { res += cc; }
            }
            Console.WriteLine(res);
            
        }
    }
}
