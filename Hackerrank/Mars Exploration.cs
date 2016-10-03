using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        int counter=0;
        for(int i=0;i<s.Length-2;i+=3)
        {
            if(!s.Substring(i,1).Equals("S"))
            {counter++;}
            if(!s.Substring(i+1,1).Equals("O"))
            {counter++;}
            if(!s.Substring(i+2,1).Equals("S"))
            {counter++;}
        }
        Console.WriteLine(counter);
    }
}
