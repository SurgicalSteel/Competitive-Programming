using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static string rever(string a)//reverse string
    {
      string x="";
      for(int y=a.Length-1;y>=0;y--)
      {x+=a.Substring(y,1);}
      return x;
    }
    static int absolutey(int a)
    {if(a<0){return a*-1;}else{return a;}}
    static int getbyte(string x)
    {
        byte[] dec = Encoding.ASCII.GetBytes(x);
        return dec[0];
    }
    static string solve(string s)
    {
        string r=rever(s);
        bool checkfun=true;
        int i=0;
        while(i<(s.Length-1)&&checkfun)
        {
            if(absolutey(getbyte(s.Substring(i+1,1))-getbyte(s.Substring(i,1)))!=absolutey(getbyte(r.Substring(i+1,1))-getbyte(r.Substring(i,1)))){checkfun=false;}
            i++;
        }
        if(checkfun){return "Funny";}else{return "Not Funny";}
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string temp;
        temp=Console.ReadLine();
        int tc;
        int.TryParse(temp,out tc);
        string[] res=new string[tc];
        for(int i=0;i<tc;i++)
        {
            temp=Console.ReadLine();
            res[i]=solve(temp);
        }
        for(int i=0;i<tc;i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}
