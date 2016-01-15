using System;
using System.Text;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
public class Test
{
    static bool find(List<string> col, string key)
    {
        if(col.Count==0){return false;}
        else
        {
            var x=from s in col where s==key select s;
            List<string> ne=x.ToList();
            if(ne.Count>0){return true;}else{return false;}
        }
    }
    public static void Main()
    {
        // your code goes here
        List<string> col=new List<string>();
        string inp=Console.ReadLine();
        while(!string.IsNullOrEmpty(inp))
        {
            string[] inpa=inp.Split();
            foreach(string s in inpa)
            {col.Add(s);}
            inp=Console.ReadLine();
        }
        //lets permute
        List<string> permut = new List<string>();
        for(int i=0;i<col.Count;i++)
        {
            for(int j=0;j<col.Count;j++)
            {
                if(i!=j&&!find(permut,col[i]+col[j]))
                {permut.Add(col[i]+col[j]);}
            }
        }
        var sp=from x in permut orderby x ascending select x;
        List<string> sortedpermut=sp.ToList();
        for(int i=0;i<sortedpermut.Count;i++)
        {Console.WriteLine(sortedpermut[i]);}
    }
}
