using System;
using System.Collections.Generic;

namespace Same_Digits_Easy
{
    class Program
    {
        static bool isSame(int x, int y, int result)
        {
            string xys = x.ToString() + y.ToString();
            string rs = result.ToString();
            char[] cxy = xys.ToCharArray();
            char[] cr = rs.ToCharArray();
            Array.Sort(cxy);
            Array.Sort(cr);
            
            return new string(cxy) == new string(cr);
        }
        static void Main(string[] args)
        {
            int low, high;
            string[] sarr = Console.ReadLine().Split(" ");
            low = int.Parse(sarr[0]);
            high = int.Parse(sarr[1]);

            List<int> lx, ly, lres;
            lx = new List<int>();
            ly = new List<int>();  
            lres = new List<int>();
            int res;

            for(int x= low; x <= high; x++)
            {
                for (int y = x+1; y <= high; y++) 
                {
                    res = x * y;
                    if (isSame(x, y, res)) 
                    {
                        lx.Add(x);
                        ly.Add(y);
                        lres.Add(res);
                    }
                } 
            }

            Console.WriteLine("{0} digit-preserving pair(s)", lres.Count);
            for(int x = 0; x < lres.Count; x++)
            {
                Console.WriteLine("x = {0}, y = {1}, xy = {2}", lx[x], ly[x], lres[x]);
            }

        }
    }
}
