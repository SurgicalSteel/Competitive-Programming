using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int sz=int.Parse(Console.ReadLine());
        int temp;
        for(int i=0;i<sz;++i)
        {
            temp=int.Parse(Console.ReadLine());
            if(temp%7==1||temp%7==0){Console.WriteLine("Second");}
            else{Console.WriteLine("First");}
        }
    }
}
