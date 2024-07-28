using System;
using System.Collections.Generic;
using System.Linq;

namespace Help_Me_With_The_Game
{
    class Program
    {
        static string translateColumn(int x)
        {
            switch (x)
            {
                case 0: return "a";
                case 1: return "b";
                case 2: return "c";
                case 3: return "d";
                case 4: return "e";
                case 5: return "f";
                case 6: return "g";
                case 7: return "h";
                default: return "";
            }
        }
        static string translateRowString(int i) { return (translateRow(i)).ToString(); }
        static int translateRow(int i) { return ((16 - i + 1)/2); }

        static HashSet<string> pieceSet = new HashSet<string> { "K", "Q", "R", "B", "N", "P", "k", "q", "r", "b", "n", "p" };
        static bool isWhite(string piece) 
        {
            return char.IsUpper(char.Parse(piece));
        }
        static bool hasPiece(string raw) { return pieceSet.Contains(raw.Substring(1, 1)); }
        static string getPiece(string raw) { return raw.Substring(1, 1); }
        static string buildNotation(string ptype, int r, int c) {
            if (ptype != "P")
            {
                return ptype.ToUpper() + translateColumn(c) + translateRowString(r);
            }
            else 
            {
                return translateColumn(c) + translateRowString(r);
            }
        }

        static List<complete> searchBlack(string ptype, List<complete> blacks)
        {
            return (from x in blacks where x.ptype == ptype select x)
                .OrderByDescending(x => x.ri)
                .ThenBy(x => x.ci)
                .ToList();
        }

        static List<complete> searchWhite(string ptype, List<complete> whites)
        {
            return (from x in whites where x.ptype == ptype select x)
                .OrderBy(x => x.ri)
                .ThenBy(x => x.ci)
                .ToList();
        }

        static List<complete> buildSorted(bool isWhite, List<complete> source) 
        {
            List<complete> res = new List<complete>();
            if (isWhite)
            {
                res.AddRange(searchWhite("K", source));
                res.AddRange(searchWhite("Q", source));
                res.AddRange(searchWhite("R", source));
                res.AddRange(searchWhite("B", source));
                res.AddRange(searchWhite("N", source));
                res.AddRange(searchWhite("P", source));
            }
            else
            {
                res.AddRange(searchBlack("K", source));
                res.AddRange(searchBlack("Q", source));
                res.AddRange(searchBlack("R", source));
                res.AddRange(searchBlack("B", source));
                res.AddRange(searchBlack("N", source));
                res.AddRange(searchBlack("P", source));
            }
            return res;
        }

        struct complete
        {
            public int ci { get; set; }
            public int ri { get; set; }

            public string ptype { get; set; }
            public string notation { get; set; }

            public complete(int ci, int ri, string ptype)
            {
                this.ci = ci;
                this.ri = translateRow(ri);
                this.ptype = ptype.ToUpper();
                this.notation = buildNotation(this.ptype, ri, this.ci);
            }
        }
        static void Main(string[] args)
        {
            string[][] m = new string[8][];
            for(int i = 0; i < 8; i++) { m[i] = new string[8]; }
            string[] sarr;
            string s;
            List<complete> blacks = new List<complete>();
            List<complete> whites = new List<complete>();
               
            for(int i = 0; i < 17; i++) 
            {
                s = Console.ReadLine();
                if ((i % 2) == 1) 
                {
                    s = s.Substring(1, s.Length - 2);
                    sarr = s.Split("|");

                    for(int j = 0; j < sarr.Length; j++)
                    {
                        if (hasPiece(sarr[j]))
                        {
                            if (isWhite(getPiece(sarr[j])))
                            {
                                whites.Add(new complete(j, i, getPiece(sarr[j]).ToUpper()));
                            }
                            else
                            {
                                blacks.Add(new complete(j, i, getPiece(sarr[j]).ToUpper()));
                            }
                        }
                    }
                }
            }

            whites = buildSorted(true, whites);
            blacks = buildSorted(false, blacks);
            string[] nblacks = new string[blacks.Count];
            string[] nwhites = new string[whites.Count];
            for (int i = 0; i < whites.Count; i++) { nwhites[i] = whites[i].notation; }
            for (int i = 0; i < blacks.Count; i++) { nblacks[i] = blacks[i].notation; }

            Console.WriteLine("White: {0}", string.Join(",", nwhites));
            Console.WriteLine("Black: {0}", string.Join(",", nblacks));
        }
    }
}
