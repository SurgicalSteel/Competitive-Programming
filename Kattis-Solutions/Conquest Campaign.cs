using System;
using System.Collections.Generic;
using System.Globalization;

namespace Conquest_Campaign
{
    class Program
    {
        struct info
        {
            public info(int i,int j)
            {
                this.i = i;
                this.j = j;
            }
            public int i;
            public int j;
        }

        static List<info> getNeighbours(int i, int j, int C, int R) {
            List<info> n = new List<info>();
            if(i-1 >= 0){n.Add(new info(i - 1, j));}
            if (j - 1 >= 0) { n.Add(new info(i, j-1)); }
            if (i + 1 < C) { n.Add(new info(i + 1, j)); }
            if (j + 1 < R) { n.Add(new info(i, j + 1)); }
            return n;
        }
        static void Main(string[] args)
        {
            int R, C, nq,ti,tj,nday=1,cellKey,cellCount;
            string[] sarr = Console.ReadLine().Split(" ");
            R = int.Parse(sarr[0]);
            C = int.Parse(sarr[1]);
            nq = int.Parse(sarr[2]);
            cellCount = R * C;

            int[][] m = new int[R][];
            int ctr = 1;
            for(int j = 0; j < R; j++)
            {
                m[j] = new int[C];
                for (int i = 0; i < C; i++)
                {
                    m[j][i] = ctr;
                    ctr++;
                }
            }
            Dictionary<int, info> visited = new Dictionary<int, info>();
            Dictionary<int, info> current = new Dictionary<int, info>();
            List<info> neighbours,tmpNeighbours;
            info currCell;
            for(int i = 0; i < nq; i++)
            {
                sarr = Console.ReadLine().Split(" ");
                tj = int.Parse(sarr[0]);
                ti = int.Parse(sarr[1]);
                cellKey = m[tj - 1][ti - 1];
                if (!current.ContainsKey(cellKey)) {
                    current.Add(cellKey, new info(ti-1, tj-1));
                }
            }

            if(current.Count == cellCount)
            {
                Console.WriteLine(nday);
                return;
            }

            nday--;

            while (current.Count>0)
            {
                neighbours = new List<info>();
                foreach(var i in current.Keys)
                {
                    currCell = current[i];
                    tmpNeighbours = new List<info>();
                    tmpNeighbours = getNeighbours(currCell.i, currCell.j, C, R);
                    for(int x = 0; x < tmpNeighbours.Count; x++)
                    {
                        cellKey = m[tmpNeighbours[x].j][tmpNeighbours[x].i];
                        if (!current.ContainsKey(cellKey) && !visited.ContainsKey(cellKey))
                        {
                            neighbours.Add(tmpNeighbours[x]);
                        }
                    }
                    cellKey = m[currCell.j][currCell.i];
                    visited.Add(cellKey, currCell);
                }
                current.Clear();
                for(int x = 0; x < neighbours.Count; x++)
                {
                    currCell = neighbours[x];
                    cellKey = m[currCell.j][currCell.i];
                    if (!current.ContainsKey(cellKey))
                    {
                        current.Add(cellKey, currCell);
                    }
                }
                nday++;
            }
            Console.WriteLine(nday);
            return;
        }
    }
}
