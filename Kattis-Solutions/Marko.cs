using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace Marko
{
    class Program
    {
        static bool getAndCompareKey(string sub, string des)
        {
            string key = "";
            switch (sub)
            {
                case "a":
                case "b":
                case "c":
                    key = "2";
                    break;
                case "d":
                case "e":
                case "f":
                    key = "3";
                    break;
                case "g":
                case "h":
                case "i":
                    key = "4";
                    break;
                case "j":
                case "k":
                case "l":
                    key = "5";
                    break;
                case "m":
                case "n":
                case "o":
                    key = "6";
                    break;
                case "p":
                case "q":
                case "r":
                case "s":
                    key = "7";
                    break;
                case "t":
                case "u":
                case "v":
                    key = "8";
                    break;
                case "w":
                case "x":
                case "y":
                case "z":
                    key = "9";
                    break;
            }
            return key == des;
        }
        static bool isMatch(string s, string key)
        {
            if(s.Length != key.Length) { return false; }
            bool valid = true;
            int i = 0;
            while(valid &&i < s.Length)
            {
                valid = getAndCompareKey(s.Substring(i, 1), key.Substring(i, 1));
                i++;
            }
            return valid;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s;
            List<string> ls = new List<string>();
            for(int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                ls.Add(s);
            }
            string k = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                if (isMatch(ls[i], k)) { count++; }
            }
            Console.WriteLine(count);
        }
    }
}
