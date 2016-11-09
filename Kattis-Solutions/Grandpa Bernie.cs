using System;
using System.Collections.Generic;
public class Test
{
    public static void Main()
    {
        // your code goes here
        int ndi,ntc,ty;
        string[] arrin;
        string tempin;
        tempin=Console.ReadLine();
        int.TryParse(tempin, out ndi);
        Dictionary<string, List<int>> d = new Dictionary<string, List<int>>();
        for(int it=0;it<ndi;it++)
        {
            arrin = Console.ReadLine().Split();
            int.TryParse(arrin[1], out ty);
            if(d.ContainsKey(arrin[0]))
            {
                d[arrin[0]].Add(ty);
            }
            else
            {
                d.Add(arrin[0],new List<int>());
                d[arrin[0]].Add(ty);
            }
        }

        foreach(KeyValuePair<string, List<int>> entry in d)
        {
            entry.Value.Sort();
        }
        tempin=Console.ReadLine();
        int.TryParse(tempin,out ntc);
        for(int it=0;it<ntc;it++)
        {
            arrin=Console.ReadLine().Split();
            int.TryParse(arrin[1],out ty);
            Console.WriteLine(d[arrin[0]][ty-1]);
        }
    }
}
