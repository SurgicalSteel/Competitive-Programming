using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static string[] breaking(string a)
    {
        string[] result=new string[3];
        int c1=-1,c2=-1,i=0;
        while(i<a.Length)
        {
            if(((a.Substring(i,1)==" ")||(a.Substring(i,1)=="-"))&&(c1<0)){c1=i;}
            else if(((a.Substring(i,1)==" ")||(a.Substring(i,1)=="-"))&&(c1>0)&&(c2<0)){c2=i;}
            i++;
        }
        result[0]=a.Substring(0,c1);
        result[1]=a.Substring(c1+1,c2-c1-1);
        result[2]=a.Substring(c2+1,a.Length-c2-1);
        return result;
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int tc;
        string inp,temp;
        inp=Console.ReadLine();
        int.TryParse(inp,out tc);
        string[] res=new string[tc];
        string[] sem=new string[3];
        for(int i=0;i<tc;i++)
        {
            temp=Console.ReadLine();
            sem=breaking(temp);
            res[i]="CountryCode="+sem[0]+",LocalAreaCode="+sem[1]+",Number="+sem[2];
        }
        for(int i=0;i<tc;i++)
        {Console.WriteLine(res[i]);}
        Console.ReadLine();
    }
}
