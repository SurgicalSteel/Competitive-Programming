using System;
using System.Collections;
using System.Collections.Generic;

namespace Metaprogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dsi = new Dictionary<string, int>();
            string xs = Console.ReadLine();
            while (!string.IsNullOrEmpty(xs))
            {
                string[] xarr = xs.Split(" ");
                if (xarr[0].Equals("define"))
                {
                    if (dsi.ContainsKey(xarr[2]))
                    { dsi.Remove(xarr[2]); }
                    dsi.Add(xarr[2], int.Parse(xarr[1]));
                }
                else if (xarr[0].Equals("eval"))
                {
                    if (!dsi.ContainsKey(xarr[1]) || !dsi.ContainsKey(xarr[3]))
                    {
                        Console.WriteLine("undefined");
                    }
                    else
                    {
                        int va = dsi[xarr[1]];
                        int vb = dsi[xarr[3]];
                        switch (xarr[2])
                        {
                            case ">":
                                Console.WriteLine("{0}", (va > vb).ToString().ToLower());
                                break;
                            case "<":
                                Console.WriteLine("{0}", (va < vb).ToString().ToLower());
                                break;
                            case "=":
                                Console.WriteLine("{0}", (va == vb).ToString().ToLower());
                                break;
                        }
                    }
                }

                xs = Console.ReadLine();
            }
        }
    }
}
