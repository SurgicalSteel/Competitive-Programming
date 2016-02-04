using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string temp;
        int tc;
        temp=Console.ReadLine();
        int.TryParse(temp, out tc);
        int[][] hashmatrix=new int[tc][];
        for(int i=0;i<tc;i++)
        {hashmatrix[i]=new int[26];}
        string[] src=new string[tc];
        for(int i=0;i<tc;i++)
        {
            src[i]=Console.ReadLine();
            for(int j=0;j<26;j++){hashmatrix[i][j]=0;}
        }
        for(int i=0;i<tc;i++)
        {
            byte[] dec=Encoding.ASCII.GetBytes(src[i]);
            for(int j=0;j<src[i].Length;j++)
            {hashmatrix[i][dec[j]-97]++;}
        }
        int x=0,y=0,counter=0;
        bool breaker;
        while(y<26)
        {
            breaker=false;
            x=0;
            while(x<tc&&!breaker)
            {
                if(hashmatrix[x][y]==0)
                {                	
                	breaker=true;
                }
                else{x++;}
                
            }
            if(!breaker){counter++;}else{breaker=false;}
            //if(((hashmatrix[x][y])>0)&&(x==tc-1)&&(y<26)){counter++;}
            y++;
        }
        Console.WriteLine(counter);
    }
}
