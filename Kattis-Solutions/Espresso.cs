using System;

namespace Espresso
{
    class Program
    {
        static int getl(string temp) 
        {
            if (!temp.Contains("L")) { return int.Parse(temp); }
            else
            {
                int len = temp.Length;
                return int.Parse(temp.Substring(0, len - 1)) + 1;
            }
        }
        static void Main(string[] args)
        {
            int n, s;
            string[] sarr = Console.ReadLine().Split(' ');
            n = int.Parse(sarr[0]);
            s = int.Parse(sarr[1]);
            string temp;
            int curr = s;
            int x, refillcount=0;
            for(int i = 0; i < n; i++) 
            {
                temp = Console.ReadLine();
                x = getl(temp);
                if((curr-x) <0)
                {
                    refillcount++;
                    curr = s-x;
                }else{
                    curr -= x;
                }
            }
            Console.WriteLine(refillcount);
        }
    }
}
