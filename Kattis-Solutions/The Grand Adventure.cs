using System;
using System.Collections;
using System.Collections.Generic;

namespace The_Grand_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            String adv;
            for(int i = 0; i < n; i++)
            {
                adv = Console.ReadLine();
                Console.WriteLine(Solve(adv));
            }
        }
        static string Solve(string s)
        {
            bool valid = true;
            Stack<string> col = new Stack<string>();
            string elem;
            for(int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i, 1) == "$" || s.Substring(i, 1) == "|" || s.Substring(i, 1) == "*")
                {
                    col.Push(s.Substring(i, 1));
                }
                else if (s.Substring(i, 1) == "t")
                {
                    if (col.Count == 0)
                    {
                        valid = false;
                        break;
                    }
                    elem = col.Peek();
                    if (elem != "|")
                    {
                        valid = false;
                    }
                    else
                    {
                        col.Pop();
                    }
                }
                else if (s.Substring(i, 1) == "b") 
                {
                    if (col.Count == 0)
                    {
                        valid = false;
                        break;
                    }
                    elem = col.Peek();
                    if (elem != "$")
                    {
                        valid = false;
                    }
                    else
                    {
                        col.Pop();
                    }
                }
                else if (s.Substring(i, 1) == "j")
                {
                    if (col.Count == 0)
                    {
                        valid = false;
                        break;
                    }
                    elem = col.Peek();
                    if (elem != "*")
                    {
                        valid = false;
                    }
                    else
                    {
                        col.Pop();
                    }
                }
                else
                {
                    continue;
                }
            }
            if(col.Count > 0)
            {
                valid = false;
            }
            if (valid)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
