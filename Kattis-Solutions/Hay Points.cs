using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hay_Points
{
    class Program
    {
        static Dictionary<string, int> dic = new Dictionary<string, int>();
        static long calculatestr(string s)
        {
            long res = 0;
            string[] arr = s.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                { res += dic[arr[i]]; }
            }
            return res;
        }
        static void Main(string[] args)
        {

            int nd, ntc;
            string[] temp = Console.ReadLine().Split();
            string tcs = "", currstr = "";
            nd = int.Parse(temp[0]);
            ntc = int.Parse(temp[1]);
            for (int i = 0; i < nd; i++)
            {
                temp = Console.ReadLine().Split();
                dic.Add(temp[0], int.Parse(temp[1]));
            }
            for (int i = 0; i < ntc; i++)
            {
                tcs = "";
                currstr = Console.ReadLine();
                while (!currstr.Equals("."))
                {
                    tcs += (currstr+" ");
                    currstr = Console.ReadLine();
                }
                Console.WriteLine(calculatestr(tcs));
            }
        }
    }
}
