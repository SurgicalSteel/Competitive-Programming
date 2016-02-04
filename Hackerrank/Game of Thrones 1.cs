using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string s=Console.ReadLine();
        byte[] dec = Encoding.ASCII.GetBytes(s);
        int[] hash=new int[26];
        for(int i=0;i<26;i++){hash[i]=0;}
        for(int i=0;i<s.Length;i++)
        {hash[dec[i]-97]++;}
        int x=0,ctrgjl=0;
        bool valid=true;
        while(x<26&&valid)
        {
            if(hash[x]%2!=0){ctrgjl++;}
            if(ctrgjl>1){valid=false;}
            x++;
        }
        if(valid){Console.WriteLine("YES");}else{Console.WriteLine("NO");}
    }
}
