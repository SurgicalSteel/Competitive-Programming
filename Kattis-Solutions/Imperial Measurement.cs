using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Imperial_Measurement
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrint = { 1000,12,3,22,10,8,3};
            string[] arrsmallstr={"th","in","ft","yd","ch","fur","mi","lea"};
            string[] arrbigstr = { "thou", "inch", "foot", "yard", "chain", "furlong", "mile", "league" };
            string[] inps = Console.ReadLine().Split();
            int ida=0, idb=0;
            if (arrsmallstr.Contains(inps[1]))
            {
                for (int i = 0; i < arrsmallstr.Length; ++i)
                {
                    if (arrsmallstr[i] == inps[1])
                    { ida = i; }
                }
            }
            if (arrsmallstr.Contains(inps[3]))
            {
                for (int i = 0; i < arrsmallstr.Length; ++i)
                {
                    if (arrsmallstr[i] == inps[3])
                    { idb = i; }
                }
            }
            if (arrbigstr.Contains(inps[1]))
            {
                for (int i = 0; i < arrbigstr.Length; ++i)
                {
                    if (arrbigstr[i] == inps[1])
                    { ida = i; }
                }
            }
            if (arrbigstr.Contains(inps[3]))
            {
                for (int i = 0; i < arrbigstr.Length; ++i)
                {
                    if (arrbigstr[i] == inps[3])
                    { idb = i; }
                }
            }
            double x = double.Parse(inps[0]);
            if (ida > idb)
            {
                if (ida - idb == 1) { x *= arrint[idb]; }
                else
                {
                    for (int i = ida - 1; i >= idb; i--) { x *= arrint[i]; }
                }

            }
            else if (ida < idb)
            {
                if (idb - ida == 1) { x /= arrint[ida]; }
                else
                {
                    for (int i = ida; i < idb; i++) { x /= arrint[i]; }
                }

            }
            Console.WriteLine("{0:F12}", x);
            Console.ReadLine();
        }
    }
}
