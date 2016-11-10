using System;
using System.Collections.Generic;
public class Test
{
    public static void Main()
    {
        Dictionary<string,string> d = new Dictionary<string,string>();
        d.Add("a","@");
        d.Add("b","8");
        d.Add("c","(");
        d.Add("d","|)");
        d.Add("e","3");
        d.Add("f","#");
        d.Add("g","6");
        d.Add("h","[-]");
        d.Add("i","|");
        d.Add("j","_|");
        d.Add("k","|<");
        d.Add("l","1");
        d.Add("m","[]\\/[]");
        d.Add("n","[]\\[]");
        d.Add("o","0");
        d.Add("p","|D");
        d.Add("q","(,)");
        d.Add("r","|Z");
        d.Add("s","$");
        d.Add("t","']['");
        d.Add("u","|_|");
        d.Add("v","\\/");
        d.Add("w","\\/\\/");
        d.Add("x","}{");
        d.Add("y","`/");
        d.Add("z","2");
        string s = Console.ReadLine();
        string res="";
        for(int i=0;i<s.Length;i++)
        {
            if(d.ContainsKey(s.Substring(i,1).ToLower()))
            {res+=d[s.Substring(i,1).ToLower()];}
            else{res+=s.Substring(i,1);}
        }
        Console.WriteLine(res);
    }
}
