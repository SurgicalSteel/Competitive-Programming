using System;
using System.Collections.Generic;

namespace Soundex
{
    class Program
    {
        static string reduce(string s)
        {
            string b = s.Substring(0, 1);
            string curr = s.Substring(0, 1);
            string temp;
            for(int i=1; i<s.Length;i++)
            {
                temp = s.Substring(i, 1);
                if (temp != curr)
                {
                    b += temp;
                    curr = temp;
                }
            }
            return b;
        }

        static string decode(Dictionary<string, string> d, string s) 
        {
            string b = "";
            string temp;
            string curr = "*";
            for(int i = 0; i < s.Length; i++)
            {
                temp = s.Substring(i, 1);
                if (d.ContainsKey(temp))
                { b += d[temp]; }
                else
                { b += curr; }
            }
            return b;
        }

        static string cleanse(string s) 
        {
            string b = "";
            for(int i = 0; i < s.Length; i++)
            {
                if(s.Substring(i,1)!= "*") { b += s.Substring(i, 1); }
            }
            return b;
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>
            {
                {"B","1"},
                {"F","1"},
                {"P","1"},
                {"V","1"},
                {"C","2"},
                {"G","2"},
                {"J","2"},
                {"K","2"},
                {"Q","2"},
                {"S","2"},
                {"X","2"},
                {"Z","2"},
                {"D","3"},
                {"T","3"},
                {"L","4"},
                {"M","5"},
                {"N","5"},
                {"R","6"},
            };

            string s = Console.ReadLine();
            while (!string.IsNullOrEmpty(s))
            {
                s = decode(d,s);
                s = reduce(s);
                s = cleanse(s);
                Console.WriteLine(s);
                s = Console.ReadLine();
            }

        }
    }
}
