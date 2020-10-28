using System;
using System.Collections.Generic;

namespace Good_Morning
{
    class Program
    {
       static Dictionary<string, position> d = new Dictionary<string, position>
       {
           { "1", new position(0,0)},
           { "2", new position(1,0)},
           { "3", new position(2,0)},
           { "4", new position(0,1)},
           { "5", new position(1,1)},
           { "6", new position(2,1)},
           { "7", new position(0,2)},
           { "8", new position(1,2)},
           { "9", new position(2,2)},
           { "0", new position(1,3)},
       };
        public struct position
        {
            public int x, y;
            public position(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static bool CheckAlign(position left, position right)
        {
            return (right.x >= left.x && right.y >= left.y);
        }

        static bool CheckAllAlign(int n)
        {
            string a, b, c, temp;
            if (n < 10) { return true; }
            else if (n >= 10 && n <= 99)
            {
                temp = n.ToString();
                a = temp.Substring(0, 1);
                b = temp.Substring(1, 1);
                return CheckAlign(d[a], d[b]);
            }
            else
            {
                temp = n.ToString();
                a = temp.Substring(0, 1);
                b = temp.Substring(1, 1);
                c = temp.Substring(2, 1);
                return CheckAlign(d[a], d[b]) && CheckAlign(d[b], d[c]);
            }
        }

        
        static int FindClosest(int n)
        {
            if (n < 10) { return n; }
            else
            {
                if (CheckAllAlign(n)) { return n; }
                else
                {
                    int up = n+1, down = n-1;
                    //bool found = false;
                    while (true)
                    {
                        if (CheckAllAlign(up))
                        { return up; }
                        else if (CheckAllAlign(down)) { return down; }
                        up++;
                        down--;
                    }
                }    
            }
        }
        
        static void Main(string[] args)
        {
            
            int tc = int.Parse(Console.ReadLine());
            for(int i = 0; i < tc; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}", FindClosest(n));
            }
        }
    }
}
