using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static int absolutey(int a)
    {if(a<0){return a*-1;}else{return a;}}
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string a=Console.ReadLine();
        string b=Console.ReadLine();
        int[] hasha,hashb;
        int counter=0;
        hasha=new int [26];
        hashb=new int [26];
        for(int i=0;i<26;i++){hasha[i]=0;hashb[i]=0;}
        byte[] deca = Encoding.ASCII.GetBytes(a);
        byte[] decb = Encoding.ASCII.GetBytes(b);
        for(int i=0;i<a.Length;i++){hasha[deca[i]-97]++;}
        for(int i=0;i<b.Length;i++){hashb[decb[i]-97]++;}
        for(int i=0;i<26;i++)
        {counter+=absolutey(hasha[i]-hashb[i]);}
        Console.WriteLine(counter);
    }
}
