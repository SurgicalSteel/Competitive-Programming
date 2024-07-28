using System;

namespace Emag_Eht_Htiw_Em_Pleh
{
    class Program
    {
        static string modify(string current, string piece, bool isWhite)
        {
            if (isWhite) { piece = piece.ToUpper(); } else { piece = piece.ToLower(); }
            string sample = current.Substring(0, 1);
            return sample + piece + sample;
        }
        static string separator = "+---+---+---+---+---+---+---+---+";

        static string buildLine(string[] rawline)
        {
            string line = "|";
            for(int i = 0; i < rawline.Length; i++) { line += (rawline[i] + "|"); }
            return line;
        }

        static int convertCol(string s)
        {
            switch (s)
            {
                case "a": return 0;
                case "b": return 1;
                case "c": return 2;
                case "d": return 3;
                case "e": return 4;
                case "f": return 5;
                case "g": return 6;
                case "h": return 7;
                default: return -1;
            }
        }

        static int convertRow(string s)
        {
            int i = int.Parse(s);
            return 8 - i;
        }

        static void draw(string[][] mat)
        {
            Console.WriteLine(separator);
            for(int i = 0; i < mat.Length; i++)
            {
                Console.WriteLine(buildLine(mat[i]));
                Console.WriteLine(separator);
            }
        }
        static void Main(string[] args)
        {
            string rsw,rsb, sw, sb;
            string[] cw, cb;
            int tj, ti;

            sw = Console.ReadLine().Remove(0, 7);
            if (sw.Length == 0) { cw = new string[0]; }
            else { cw = sw.Split(","); }

            sb = Console.ReadLine().Remove(0, 7);
            if (sb.Length == 0) { cb = new string[0]; }
            else
            { cb = sb.Split(","); }

            for(int i = 0; i < cw.Length; i++)
            {
                if(cw[i].Length == 2)
                {
                    cw[i] = "P" + cw[i];
                }
            }

            for (int i = 0; i < cb.Length; i++)
            {
                if (cb[i].Length == 2)
                {
                    cb[i] = "P" + cb[i];
                }
            }

            string[][] mat = new string[8][];
            for (int j = 0; j < mat.Length; j++) { mat[j] = new string[8]; }

            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if((i+j)%2 == 0) { mat[j][i] = "..."; } else { mat[j][i] = ":::"; }
                }
            }

            for(int x = 0; x < cw.Length; x++)
            {
                tj = convertRow(cw[x].Substring(2, 1));
                ti = convertCol(cw[x].Substring(1, 1));
                mat[tj][ti] = modify(mat[tj][ti], cw[x].Substring(0, 1), true);
            }

            for (int x = 0; x < cb.Length; x++)
            {
                tj = convertRow(cb[x].Substring(2, 1));
                ti = convertCol(cb[x].Substring(1, 1));
                mat[tj][ti] = modify(mat[tj][ti], cb[x].Substring(0, 1), false);
            }

            draw(mat);
        }
    }
}
