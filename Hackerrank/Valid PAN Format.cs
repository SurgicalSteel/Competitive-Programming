using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static string solve(string s)
    {
       int i=0;
       bool valid=true;
       while(i<s.Length&&valid)
       {
        byte[] dec = Encoding.ASCII.GetBytes(s.Substring(i, 1));
            if((dec[0]>64&&dec[0]<91)&&(i<5||i==9)){i++;}
            else if(dec[0]>=48&&dec[0]<=57&&(i>4)&&(i<9)){i++;}
            else{valid=false;}
       }
       if(valid){return "YES";}else{return "NO";}
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int tc;
        string temp;
        temp=Console.ReadLine();
        int.TryParse(temp,out tc);
        string[] res=new string[tc];
        for(int i=0;i<tc;i++)
        {
            res[i]=Console.ReadLine();
        }
        for(int i=0;i<tc;i++)
        {Console.WriteLine(solve(res[i]));}
        Console.ReadLine();
    }
}
