using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        if(n<3){Console.WriteLine("0");}
        else if(n==3)
        {
            if(s.Equals("010")){Console.WriteLine("1");}
            else{Console.WriteLine("0");}
        }
        else
        {
            int counter=0;
            int i=0;
            while(i<s.Length-2)
            {
                if(s.Substring(i,3).Equals("010")){counter++;i+=3;}
                else{i++;}
            }
            Console.WriteLine(counter);
        }
    }
}
