using System;

namespace Krizaljka
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            string a = arr[0];
            string b = arr[1];
            int pa = -1, pb = -1;
            //string samechar = "";
            //int fi=0, fj=0;
            bool flagbreak=false;
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if ((a.Substring(j, 1) == b.Substring(i, 1)) && (pa == -1) && (pb == -1))
                    {
                        pa = j;
                        pb = i;
                        flagbreak=true;
                        break;
                    }
                }
                if(flagbreak){break;}
            }
            string[][] m = new string[b.Length][];
            for (int j = 0; j < b.Length; j++)
            {
                m[j] = new string[a.Length];
                for (int i= 0; i < a.Length; i++)
                {
                    m[j][i] = ".";
                }
            }
            
            for (int i = 0; i < a.Length; i++)
            {
                m[pb][i] = a.Substring(i, 1);
            }
            for (int j = 0; j < b.Length; j++)
            {
                m[j][pa] = b.Substring(j, 1);
            }
            
            for (int j = 0; j < b.Length; j++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(m[j][i]);
                }
                Console.WriteLine();
            }
        }
    }
}
