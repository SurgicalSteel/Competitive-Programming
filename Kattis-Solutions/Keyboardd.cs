using System;
using System.Collections.Generic;
namespace Keyboardd
{
    class Program
    {
        static void Main(string[] args)
        {
            string stemp;
            int tempcount;
            string sori = Console.ReadLine();
            string smod = Console.ReadLine();
            Dictionary<string, int> dori = new Dictionary<string, int>();
            Dictionary<string, int> dmod = new Dictionary<string, int>();

            for(int i = 0; i < sori.Length; i++)
            {
                stemp = sori.Substring(i, 1);
                if (dori.ContainsKey(stemp))
                {
                    tempcount = dori[stemp];
                    tempcount += 1;
                    dori.Remove(stemp);
                    dori.Add(stemp, tempcount);
                }
                else
                {
                    dori.Add(stemp, 1);
                }
            }

            for (int i = 0; i < smod.Length; i++)
            {
                stemp = smod.Substring(i, 1);
                if (dmod.ContainsKey(stemp))
                {
                    tempcount = dmod[stemp];
                    tempcount += 1;
                    dmod.Remove(stemp);
                    dmod.Add(stemp, tempcount);
                }
                else
                {
                    dmod.Add(stemp, 1);
                }
            }

            string res = "";

            foreach(string key in dmod.Keys)
            {
                if(dmod[key] != dori[key]) { res += key; }
            }

            Console.WriteLine(res);
        }
    }
}
