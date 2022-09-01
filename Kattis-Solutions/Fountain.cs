using System;
using System.Collections.Generic;
namespace Fountain
{
    class Program
    {
        class cell
        {
            public int r;
            public int c;
            public cell(int r, int c) { this.r = r; this.c = c; }
        }

        static bool checkvalid(int nr, int nc, int r, int c)
        {
            return r >= 0 && r < nr && c >= 0 && c < nc;
        }

        static List<cell> getNeighbors(string[][] mat, cell cell, int nr, int nc) 
        {
            List<cell> l = new List<cell>();
            cell cl, cd, cr;
            if (checkvalid(nr, nc, cell.r, cell.c - 1)) 
            {
                if (mat[cell.r][cell.c - 1] == ".")
                {
                    if (checkvalid(nr, nc, cell.r + 1, cell.c))
                    {
                        if (mat[cell.r + 1][cell.c] == "#")
                        {
                            cl = new cell(cell.r, cell.c - 1); l.Add(cl);
                        }
                    }
                    /*
                    else
                    {
                        cl = new cell(cell.r, cell.c - 1); l.Add(cl);
                    }
                    */
                }
                 
            }
            if (checkvalid(nr, nc, cell.r, cell.c + 1)) 
            {
                if (mat[cell.r][cell.c + 1] == ".")
                {
                    if (checkvalid(nr, nc, cell.r + 1, cell.c))
                    {
                        if (mat[cell.r + 1][cell.c] == "#")
                        {       
                            cr = new cell(cell.r, cell.c + 1); l.Add(cr);
                        }
                    }
                    /*
                    else 
                    {
                        cr = new cell(cell.r, cell.c + 1); l.Add(cr);
                    }
                    */
                }
            }
            if (checkvalid(nr, nc, cell.r + 1, cell.c)) {
                if (mat[cell.r+1][cell.c] == ".")
                {
                    cd = new cell(cell.r + 1, cell.c); l.Add(cd);
                }
            }
            return l;
        }

        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(' ');
            int r = int.Parse(sarr[0]), c = int.Parse(sarr[1]);
            string[][] mat = new string[r][];
            string s, ss;
            Queue<cell> q = new Queue<cell>();
            cell tcell;
            for (int i = 0; i < r; i++)
            {
                s = Console.ReadLine();
                mat[i] = new string[c];
                for (int j = 0; j < c; j++)
                {
                    ss = s.Substring(j, 1);
                    mat[i][j] = ss;
                    if (ss.Equals("V")) { q.Enqueue(new cell(i, j)); }
                }
            }

            while (q.Count > 0)
            {
                tcell = q.Dequeue();
                mat[tcell.r][tcell.c] = "V";
                List<cell> neighbors = getNeighbors(mat, tcell, r, c);
                for (int i = 0; i < neighbors.Count; i++) { q.Enqueue(neighbors[i]); }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(mat[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
