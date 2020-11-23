using System;

namespace Score
{
    class Program
    {
        const int HOME = 0, TIE = 1, AWAY = 2;

        static string formatSecond(int s)
        {
            string res = ":", secmark;
            int ts, tm;
            ts = s % 60;
            s = s - ts;
            tm = s / 60;
            if (ts == 0) { secmark = "00"; }
            else if (ts < 10) { secmark = "0" + ts.ToString(); }
            else { secmark = ts.ToString(); }
            res = tm.ToString() + res + secmark;
            return res;
        }

        static int getSecond(string s)
        {
            string[] sarr = s.Split(":");
            int res = 0;
            res = int.Parse(sarr[0]) * 60 + int.Parse(sarr[1]);
            return res;
        }

        static int subtract(string a, string b)
        {
            return getSecond(a) - getSecond(b);
        }

        static void Main(string[] args)
        {
            int state = TIE;
            int n = int.Parse(Console.ReadLine());
            int tph = 0, tpa = 0, tlhs = 0, tlas = 0;
            string lastMark = "00:00",sarr0,winner;
            string[] sarr;
            int point;
            for(int i = 0; i < n; i++)
            {
                sarr = Console.ReadLine().Split(" ");
                sarr0 = sarr[0];
                if (sarr0 == "H")
                { tph += int.Parse(sarr[1]); }
                else
                { tpa += int.Parse(sarr[1]); }

                if (state == TIE)
                {
                    if (tph > tpa)
                    { 
                        state = HOME;
                        lastMark = sarr[2];
                    }
                    else if (tpa > tph)
                    { 
                        state = AWAY;
                        lastMark = sarr[2];
                    }
                    
                }else if(state == HOME)
                {
                    if (tpa > tph)
                    { 
                        state = AWAY;
                        tlhs += subtract(sarr[2], lastMark);
                        lastMark = sarr[2];
                    }
                    else if (tpa == tph)
                    { 
                        state = TIE;
                        tlhs += subtract(sarr[2], lastMark);
                        lastMark = sarr[2];
                    }
                }else if (state == AWAY)
                {
                    if (tph > tpa)
                    {
                        state = HOME;
                        tlas += subtract(sarr[2], lastMark);
                        lastMark = sarr[2];
                    }
                    else if (tpa == tph)
                    {
                        state = TIE;
                        tlas += subtract(sarr[2], lastMark);
                        lastMark = sarr[2];
                    }
                }
                //Console.WriteLine(state + "    " + lastMark);
            }
            if (state == HOME)
            { tlhs += subtract("32:00", lastMark); }
            else if (state == AWAY)
            { tlas += subtract("32:00", lastMark); }

            if (tpa > tph) { winner = "A"; } else { winner = "H"; }
            Console.WriteLine("{0} {1} {2}", winner, formatSecond(tlhs), formatSecond(tlas));
        }
    }
}
