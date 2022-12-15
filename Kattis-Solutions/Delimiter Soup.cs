using System;
using System.Collections.Generic;
using System.Linq;
namespace Delimiter_Soup
{
    class Program
    {
        struct cp
        {
            private string character;
            private int position;

            public string getCharacter() { return this.character; }
            public int getPosition() { return this.position; }

            public cp(int pos, string cha)
            {
                this.position = pos;
                this.character = cha;
            }

        }

        static bool match(string a, string b)
        {
            return (a == "{" && b == "}") || (a == "}" && b == "{") ||
                    (a == "[" && b == "]") || (a == "]" && b == "[") ||
                    (a == "(" && b == ")") || (a == ")" && b == "(");
        }


        static void Main(string[] args)
        {
            int numChar = int.Parse(Console.ReadLine());
            String s = Console.ReadLine();
            string temps;
            List<cp> l = new List<cp>();
            Stack<cp> stack = new Stack<cp>();
            for(int i = 0; i < s.Length; i++) 
            {
                temps = s.Substring(i, 1);
                if (temps!= " ") 
                {l.Add(new cp(i, temps));}
            }
            cp tcp, stcp;
            bool err = false;
            for(int i = 0; i < l.Count; i++)
            {
                tcp = l[i];
                if(tcp.getCharacter().Equals("[") || tcp.getCharacter().Equals("{") || tcp.getCharacter().Equals("("))
                {
                    stack.Push(tcp);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("{0} {1}", tcp.getCharacter(), tcp.getPosition());
                        err = true;
                        break;
                    }
                    else {
                        stcp = stack.Pop();
                        if (!match(stcp.getCharacter(), tcp.getCharacter())){
                            Console.WriteLine("{0} {1}", tcp.getCharacter(), tcp.getPosition());
                            err = true;
                            break;
                        }
                    }
                }
            }

            if (!err) { Console.WriteLine("ok so far"); }

        }
    }
}
