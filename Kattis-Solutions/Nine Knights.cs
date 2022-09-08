using System;
using System.Collections.Generic;
namespace Nine_Knights
{
    class Program
    {
        class cell
        {
            public int r;
            public int c;
            public cell(int r, int c) { this.r = r; this.c = c; }
        }

        static bool isValidCell (int nr, int nc, int r, int c)
        {
            return r >= 0 && r < nr && c >= 0 && c < nc;
        }

        static bool isSingleValid(cell c, string[][] mat, int nr, int nc)
        {
            if (isValidCell(nr, nc, c.r + 2, c.c - 1)) { if (mat[c.r + 2][c.c - 1] == "k") { return false; } }
            if (isValidCell(nr, nc, c.r + 2, c.c + 1)) { if (mat[c.r + 2][c.c + 1] == "k") { return false; } }
            if (isValidCell(nr, nc, c.r - 2, c.c - 1)) { if (mat[c.r - 2][c.c - 1] == "k") { return false; } }
            if (isValidCell(nr, nc, c.r - 2, c.c + 1)) { if (mat[c.r - 2][c.c + 1] == "k") { return false; } }
            if (isValidCell(nr, nc, c.r + 1, c.c - 2)) { if (mat[c.r + 1][c.c - 2] == "k") { return false; } }
            if (isValidCell(nr, nc, c.r + 1, c.c + 2)) { if (mat[c.r + 1][c.c + 2] == "k") { return false; } }
            if (isValidCell(nr, nc, c.r - 1, c.c - 2)) { if (mat[c.r - 1][c.c - 2] == "k") { return false; } }
            if (isValidCell(nr, nc, c.r - 1, c.c + 2)) { if (mat[c.r - 1][c.c + 2] == "k") { return false; } }
            return true;
        }

        static bool isAllValid(List<cell> l, string[][] mat, int nr, int nc) 
        {
            bool valid = true;
            for(int i = 0; i < l.Count; i++) 
            {
                valid = valid && isSingleValid(l[i], mat, nr, nc);
                if (!valid) { return false; }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //string[] sarr = Console.ReadLine().Split(' ');
            int r = 5, c = 5;
            string[][] mat = new string[r][];
            string s, ss;
            List<cell> l = new List<cell>();
            cell tcell;
            for (int i = 0; i < r; i++)
            {
                s = Console.ReadLine();
                mat[i] = new string[c];
                for (int j = 0; j < c; j++)
                {
                    ss = s.Substring(j, 1);
                    mat[i][j] = ss;
                    if (ss.Equals("k")) { l.Add(new cell(i, j)); }
                }
            }
            bool valid = isAllValid(l, mat, r, c);
            if (valid && l.Count==9) { Console.WriteLine("valid"); } else { Console.WriteLine("invalid"); }
        }
    }
}
