using System;
using System.Collections.Generic;
using System.Linq;
namespace Gandalfs_Spell
{
    class Program
    {
        static void print(bool b)
        {
            if (b) { Console.WriteLine("True"); } else { Console.WriteLine("False"); }
        }
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            string[] sarr = Console.ReadLine().Split(' ');
            string ctemp,stemp;
            if(code.Length != sarr.Length) { print(false); return; }
            
            Dictionary<string, string> fwd = new Dictionary<string, string>();
            Dictionary<string, string> rev = new Dictionary<string, string>();
            for (int i = 0; i < code.Length; i++) 
            {
                ctemp = code.Substring(i, 1);
                stemp = sarr[i];
                if (!fwd.ContainsKey(ctemp)) 
                {
                    if (!rev.ContainsKey(stemp)) 
                    {
                        fwd.Add(ctemp, stemp);
                        rev.Add(stemp, ctemp);
                    }
                    else { print(false); return; }
                     
                }
                else 
                {
                    if (fwd[ctemp] != stemp) { print(false); return; }
                }
            }
            print(true);
        }
    }
}
