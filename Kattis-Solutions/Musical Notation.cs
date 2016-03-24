using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musical_Notation
{
    class Program
    {
        static int getlength(string s)
        {
            return int.Parse(s.Substring(1));
        }
        struct noteline
        {
            public noteline(string n, string l)
            {
                this.note = n;
                this.line = l;
            }
            public noteline(string n)
            {
                this.note = n;
                this.line = "";
            }
            public string note, line;
        };
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] seqnote = Console.ReadLine().Split();
            List<noteline> all = new List<noteline>();
            all.Add(new noteline("G"));
            all.Add(new noteline("F"));
            all.Add(new noteline("E"));
            all.Add(new noteline("D"));
            all.Add(new noteline("C"));
            all.Add(new noteline("B"));
            all.Add(new noteline("A"));
            all.Add(new noteline("g"));
            all.Add(new noteline("f"));
            all.Add(new noteline("e"));
            all.Add(new noteline("d"));
            all.Add(new noteline("c"));
            all.Add(new noteline("b"));
            all.Add(new noteline("a"));
            for (int i = 0; i < num; i++)
            {
                int idx = all.FindIndex(item => item.note == seqnote[i].Substring(0,1));
                for (int x = 0; x < all.Count; x++)
                {
                    string not=all[x].note, lin=all[x].line;
                    if (idx == x)
                    {
                        if (seqnote[i].Length == 1) { lin += "*"; }
                        else
                        {
                            for (int y = 0; y < getlength(seqnote[i]); y++) { lin += "*"; }
                        }
                    }
                    else
                    {
                        if(not=="G"|| not == "E"|| not == "C"|| not == "A"|| not == "f"|| not == "d"|| not == "c"|| not == "b") 
                        { 
                        	if (seqnote[i].Length == 1) { lin += " "; }
	                        else
	                        {
	                            for (int y = 0; y < getlength(seqnote[i]); y++) { lin += " "; }
	                        } 
                        }
                        else {
                        	if (seqnote[i].Length == 1) { lin += "-"; }
	                        else
	                        {
	                            for (int y = 0; y < getlength(seqnote[i]); y++) { lin += "-"; }
	                        } 
                        }
                    }
                    all[x] = new noteline(not, lin);
                }
                if (i + 1 != num)
                {
                    for (int x = 0; x < all.Count; x++)
                    {
                        string not = all[x].note, lin = all[x].line;
                        if (not == "G" || not == "E" || not == "C" || not == "A" || not == "f" || not == "d" || not == "c" || not == "b") { lin += " "; }
                        else { lin += "-"; }
                        all[x] = new noteline(not, lin);
                    }
                }
            }
            for (int i = 0; i < all.Count; i++)
            {
                Console.WriteLine("{0}: {1}", all[i].note, all[i].line);
            }
            Console.ReadLine();
        }
    }
}
