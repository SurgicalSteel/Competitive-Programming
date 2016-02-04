using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static int counterchar(char single, char[] collection, int collectionsize)
        {
            int num=0;
            for(int i=0;i<collectionsize;i++)
            {
                if(collection[i]==single){num++;}
            }
            return num;
        }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string a;
            a = Console.ReadLine();
            char[] inp = new char[a.Length];
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++) { alphabet[i] = Convert.ToChar(97 + i); }
            a = a.ToLower();
            inp = a.ToCharArray();
            int iter = 0;
            bool valid = true;
            while (iter < 26 && valid)
            {
                if (counterchar(alphabet[iter], inp, a.Length) == 0) { valid = false; }
                else { iter++; }
            }
            if (valid) { Console.WriteLine("pangram"); } else { Console.WriteLine("not pangram"); }
            Console.ReadLine();
    }
}
