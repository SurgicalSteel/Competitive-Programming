using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static int solve(string a)
    {
        if((a.Substring(0,10).Equals("hackerrank")&&a.Length==10)||(a.Substring(0,10).Equals("hackerrank")&&a.Substring(a.Length-10,10).Equals("hackerrank")&&a.Length>=20)){return 0;}
        else if((a.Substring(0,10).Equals("hackerrank")&&a.Length>10)){return 1;}
        else if(a.Substring(a.Length-10,10).Equals("hackerrank")&&a.Length>10){return 2;}
        else {return -1;}
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
    }
}
