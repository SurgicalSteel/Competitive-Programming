using System;
using System.Collections.Generic;
namespace An_I_for_an_Eye
{
    class Program
    {

        static string transingle(string dic, string src)
        {
            if (Char.IsUpper(src, 0))
            {
                return dic.ToUpper();
            }
            return dic;
        }

        static string trans(Dictionary<string,string> d, string source) 
        {
            int i = 0;
            string res = "";
            while (i < source.Length) 
            {
                if (i + 4 <= source.Length)
                {
                    if (d.ContainsKey(source.Substring(i, 4).ToLower())) 
                    {
                        res += transingle(d[source.Substring(i, 4).ToLower()], source.Substring(i, 4));
                        i += 4;
                    }
                    else
                    {
                        if (d.ContainsKey(source.Substring(i, 3).ToLower()))
                        {
                            res += transingle(d[source.Substring(i, 3).ToLower()], source.Substring(i, 3));
                            i += 3;
                        }
                        else
                        {
                            if (d.ContainsKey(source.Substring(i, 2).ToLower()))
                            {
                                res += transingle(d[source.Substring(i, 2).ToLower()], source.Substring(i, 2));
                                i += 2;
                            }
                            else 
                            {
                                res += source.Substring(i, 1);
                                i += 1;
                            }
                        }
                    }
                }
                else if (i + 3 <= source.Length)
                {
                    if (d.ContainsKey(source.Substring(i, 3).ToLower()))
                    {
                        res += transingle(d[source.Substring(i, 3).ToLower()], source.Substring(i, 3));
                        i += 3;
                    }
                    else 
                    {
                        if (d.ContainsKey(source.Substring(i, 2).ToLower()))
                        {
                            res += transingle(d[source.Substring(i, 2).ToLower()], source.Substring(i, 2));
                            i += 2;
                        }
                        else
                        {
                            res += source.Substring(i, 1);
                            i += 1;
                        }
                    }
                }
                else if(i+2 <= source.Length)
                {
                    if (d.ContainsKey(source.Substring(i, 2).ToLower()))
                    {
                        res += transingle(d[source.Substring(i, 2).ToLower()], source.Substring(i, 2));
                        i += 2;
                    }
                    else
                    {
                        res += source.Substring(i, 1);
                        i += 1;
                    }
                }
                else 
                {
                    res += source.Substring(i, 1);
                    i += 1;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>()
            {
                { "four","4" },
                { "and","&" },
                { "one","1" },
                { "won","1" },
                { "too", "2" },
                { "two", "2" },
                { "for", "4" },
                { "bea", "b" },
                { "bee", "b" },
                { "sea", "c" },
                { "see", "c" },
                { "eye", "i" },
                { "owe", "o" },
                { "are", "r" },
                { "you", "u" },
                { "why", "y" },
                { "at", "@" },
                { "to", "2" },
                { "be", "b" },
                { "oh", "o" },
            };
            int n = int.Parse(Console.ReadLine());
            string s;
            for(int x = 0; x < n; x++) 
            {
                s = Console.ReadLine();
                Console.WriteLine(trans(d, s));
            }
        }
    }
}

