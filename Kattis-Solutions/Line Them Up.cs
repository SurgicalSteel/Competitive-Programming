using System;
using System.Text;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
public class Test
{
    public static void Main()
    {
        string inp;
        List<string> name=new List<string>();
        int n;
        inp=Console.ReadLine();
        int.TryParse(inp, out n);
        for(int i=0;i<n;i++)
        {
            inp=Console.ReadLine();
            name.Add(inp);
        }
        bool inc=true,dec=true;
        for(int x=1;x<n;x++)
        {
            if(string.Compare(name[x-1],name[x])==-1)
            {dec=false;}
            else{inc=false;}
        }
        if(!dec&&inc){Console.WriteLine("INCREASING");}
        else if(dec&&!inc){Console.WriteLine("DECREASING");}
        else if(!dec&&!inc){Console.WriteLine("NEITHER");}
    }
}
