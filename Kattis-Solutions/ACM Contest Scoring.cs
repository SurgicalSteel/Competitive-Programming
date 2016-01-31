using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ACM_Contest_Scoring
{
    class MainClass
    {

        struct submission{public int time; public string problem; public string verdict;};
        public static void Main(string[] args)
        {
            int totaltime = 0;
            int totalsolved = 0;
            List<submission> log = new List<submission>();
            submission temp;
            string logline = Console.ReadLine();
            while (!logline.Equals("-1"))
            {
                string[] res = logline.Split();
                temp.time = int.Parse(res[0]);
                temp.problem = res[1];
                temp.verdict = res[2];
                log.Add(temp);
                logline = Console.ReadLine();
            }
            //solve
            for(int i=0;i<log.Count;i++)
            {
                int ctrwrong = 0;
                if(log[i].verdict.Equals("right"))
                {
                    totalsolved++;
                    for (int j = 0; j < i; j++)
                    {
                        if (log[j].problem==log[i].problem && log[j].verdict!="right")
                        {ctrwrong++;}
                    }
                    totaltime += (log[i].time + (ctrwrong * 20));
                }
                
            }
            Console.WriteLine("{0} {1}", totalsolved, totaltime);
        }
    }
}
