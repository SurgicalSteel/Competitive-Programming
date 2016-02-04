using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static string solve(string sa, string sb)//check by common letter which appears in both strings
    {
        int[] arsa=new int[26];
        int[] arsb=new int[26];
        for(int i=0;i<sa.Length;i++)
        {
            byte[] dec = Encoding.ASCII.GetBytes(sa.Substring(i,1));
            arsa[dec[0]-97]++;
        }
        for(int i=0;i<sb.Length;i++)
        {
            byte[] dec = Encoding.ASCII.GetBytes(sb.Substring(i,1));
            arsb[dec[0]-97]++;
        }
        int x=0;
        bool same=false;
        while(x<26&&!same)
        {
            if(arsa[x]>0&&arsb[x]>0){same=true;}
            x++;
        }
        if(same){return "YES";}else{return "NO";}
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string inp,ds,dd;
        inp=Console.ReadLine();
        int tc,ctr=0;
        int.TryParse(inp, out tc);
        while(ctr<tc)
        {
            ds=Console.ReadLine();
            dd=Console.ReadLine();
            Console.WriteLine(solve(ds,dd));
            ctr++;
        }
    }
}
