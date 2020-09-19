using System;
using System.Collections.Generic;
using System.Linq;

namespace Competitive_Arcade_Basketball
{
    class Program
    {
        struct player
        {
            public string name;
            public int score;
            public int idxReach;

            public player(string name)
            {
                this.name = name;
                this.score = 0;
                this.idxReach = -1;
            }
            public void addScore(int n)
            {
                this.score = this.score + n;
            }
            public void setIdxReach(int n)
            {
                this.idxReach = n;
            }
            
        }
        static void Main(string[] args)
        {
            int np, minpoint, nl;
            string[] tempArr;
            string temps;
            player tempplayer;
            tempArr = Console.ReadLine().Split(" ");
            np = int.Parse(tempArr[0]);
            minpoint = int.Parse(tempArr[1]);
            nl = int.Parse(tempArr[2]);
            List<player> players = new List<player>();
            Dictionary<string, int> nameIdxMap = new Dictionary<string, int>();
            for(int x = 0; x < np; x++)
            {
                temps = Console.ReadLine();
                players.Add(new player(temps));
                nameIdxMap.Add(temps, x);
            }
            for(int x = 0; x < nl; x++)
            {
                tempArr = Console.ReadLine().Split(" ");
                int idx = nameIdxMap[tempArr[0]];
                tempplayer = players[idx];
                tempplayer.addScore(int.Parse(tempArr[1]));
                players[idx] = tempplayer;
                if(players[idx].idxReach== -1 && players[idx].score >= minpoint)
                {
                    tempplayer = players[idx];
                    tempplayer.setIdxReach(x);
                    players[idx] = tempplayer;
                }
            }
            List<player> filtered = (from p in players where p.idxReach >0 select p).ToList();
            if (filtered.Count == 0)
            {
                Console.WriteLine("No winner!");
            }
            else
            {
                filtered.OrderBy(p => p.idxReach);
                for(int i = 0; i < filtered.Count; i++)
                {
                    Console.WriteLine("{0} wins!", filtered[i].name);
                }
            }
        }
    }
}
