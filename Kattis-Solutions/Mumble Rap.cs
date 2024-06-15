using System;
using System.Collections.Generic;

namespace Mumble_Rap
{
    class Program
    {
        static bool isInt(string c)
        {
            switch (c)
            {
                case "0": 
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    return true;
                default:
                    return false;
            }
        }

        static int toInt(List<string> ls)
        {
            string s = "";
            foreach(string st in ls){ s += st; }
            return int.Parse(s);
        }

        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int maxi = 0;
            string currs,fars="";
            bool isi = false;
            for(int i = 0; i < len; i++)
            {
                currs = s.Substring(i, 1);
                if (isInt(currs) && !isi)
                {
                    isi = true;
                    fars += currs;
                }else if(isInt(currs) && isi)
                {
                    fars += currs;
                }else if((!isInt(currs) && isi))
                {
                    isi = false;
                    maxi = Math.Max(maxi, int.Parse(fars));
                    fars = "";
                }

                if((i+1==len) && isi && isInt(currs))
                {
                    isi = false;
                    maxi = Math.Max(maxi, int.Parse(fars));
                    fars = "";
                }
            }
            Console.WriteLine(maxi);
        }
    }
}
