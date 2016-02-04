using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static bool contains(string a,string b) //a>b
    {
        bool valid=false;
        int x=0;
        while((x<=(a.Length-b.Length))&&(!valid))
        {   
            if(a.Substring(x,b.Length).Equals(b))
            {valid=true;}
            else
            { x++;}
        }
        return valid;
    }

    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int tc,counter=0;
        string temp;
        temp=Console.ReadLine();
        int.TryParse(temp,out tc);
        for(int i=0;i<tc;i++)
        {
            temp=Console.ReadLine();
            if(contains(temp.ToLower(),"hackerrank")){counter++;}
            //Console.WriteLine(temp.ToLower());
        }
        Console.WriteLine(counter);
        Console.ReadLine();
    }
}
