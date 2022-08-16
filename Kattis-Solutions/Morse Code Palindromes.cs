using System;
using System.Collections.Generic;
namespace Morse_Code_Palindromes
{
    class Program
    {
        static string cleanse(Dictionary<string, string> d, string s) 
        {
            s = s.ToUpper();
            string res = "";
            for(int i = 0; i < s.Length; i++) 
            {
                if (d.ContainsKey(s.Substring(i, 1))) { res += s.Substring(i, 1); }
            }
            return res;
        }
        // a b b a
        // 0 1 2 3

        // a b b b a
        // 0 1 2 3 4
        
        static bool ispalindrome(string s) 
        {
            int maxidx = s.Length-1;
            for(int i = 0; i < (s.Length / 2); i++) 
            {
                if (!s.Substring(i, 1).Equals(s.Substring(maxidx - i, 1))){ return false; }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> morse = 
                new Dictionary<string, string>() { 
                    { "A", "01" }, { "B", "1000" }, { "C", "1010" }, { "D", "100" }, { "E", "0" }, { "F", "0010" },
                    { "G", "110" }, { "H", "0000" }, { "I", "00" }, { "J", "0111" }, { "K", "101" }, { "L", "0100" },
                    { "M", "11" }, { "N", "10" }, { "O", "111" }, { "P", "0110" }, { "Q", "1101" }, { "R", "010" },
                    { "S", "000" }, { "T", "1" }, { "U", "001" }, { "V", "0001" }, { "W", "011" }, { "X", "1001" },
                    { "Y", "1011" }, { "Z", "1100" }, { "0", "11111" }, { "1", "01111" }, { "2", "00111" }, { "3", "00011" },
                    { "4", "00001" }, { "5", "00000" }, { "6", "10000" }, { "7", "11000" }, { "8", "11100" }, { "9", "11110" }
                };
            string s = Console.ReadLine();
            if (s.Length == 0) { Console.WriteLine("0"); return; }
            s = cleanse(morse, s);
            if (s.Length == 0) { Console.WriteLine("0"); return; }
            string trans = "";
            for(int i = 0; i < s.Length; i++) 
            {
                trans += morse[s.Substring(i, 1)];
            }
            if (ispalindrome(trans)) { Console.WriteLine("1"); } else { Console.WriteLine("0"); }
        }
    }
}
