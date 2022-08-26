using System;
using System.Collections.Generic;
using System.Linq;

namespace Sky_Islands
{
    class Program
    {
        class Vertex
        {
            public int data;
            public List<int> neighbor;

            public Vertex(int d)
            {
                this.data = d;
                this.neighbor = new List<int>();
            }
            public void addNeighbor(int x)
            {
                if (!neighbor.Contains(x)) { neighbor.Add(x); }
            }
            public List<int> getNeighbors() { return this.neighbor; }
        }



        static void Main(string[] args)
        {
            int nV, nE;
            string[] sarr;
            List<Vertex> graph = new List<Vertex>();
            
            sarr = Console.ReadLine().Split(' ');
            nV = int.Parse(sarr[0]);
            nE = int.Parse(sarr[1]);
            int ta, tb, curr;
            
            for(int i = 1; i <= nV; i++) { graph.Add(new Vertex(i)); }

            for(int i = 0; i < nE; i++) 
            {
                sarr = Console.ReadLine().Split(' ');
                ta = int.Parse(sarr[0]);
                tb = int.Parse(sarr[1]);
                graph[ta - 1].addNeighbor(tb);
                graph[tb - 1].addNeighbor(ta);
            }

            if (nV > (nE + 1)) { Console.WriteLine("NO"); return; }

            //DFS
            List<int> tempNeighbors;

            bool[] visited = new bool[nV];
            for(int i = 0; i < nV; i++) { visited[i] = false; }

            Stack<int> stack = new Stack<int>();
            stack.Push(1);

            while(stack.Count > 0) 
            {
                curr = stack.Pop();
                visited[curr - 1] = true;
                tempNeighbors = graph[curr - 1].getNeighbors();
                for(int i = 0; i < tempNeighbors.Count; i++) 
                {
                    if (!visited[tempNeighbors[i]-1]) { stack.Push(tempNeighbors[i]); }
                }
            }

            int count = 0;
            for(int i = 0; i < nV; i++) { if (visited[i]) { count++; } }

            if(count == nV) { Console.WriteLine("YES"); } else { Console.WriteLine("NO"); }
        }
    }
}
