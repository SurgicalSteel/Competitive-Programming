using System;

namespace Odd_Gnome
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLine = int.Parse(Console.ReadLine());
            string[] sarr;
            int ta, tb, tz, dza, dab, idx=0;
            for(int x = 0; x< nLine; x++)
            {
                sarr = Console.ReadLine().Split(" ");
                if(sarr.Length == 4) { 
                    Console.WriteLine(2); 
                    continue; 
                }
                for(int i = 2; i < sarr.Length-1; i++)
                {
                    tz = int.Parse(sarr[i - 1]);
                    ta = int.Parse(sarr[i]);
                    tb = int.Parse(sarr[i + 1]);

                    if((tb-tz)==1) { 
                        idx = i;
                        Console.WriteLine(idx);
                        break;
                    }

                }
                
            }
        }
    }
}
