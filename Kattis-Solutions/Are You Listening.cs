using System;
using System.Collections.Generic;

namespace Are_You_Listening
{
    class Program
    {
        static bool checkCirclesIntersection(int px1, int py1, int r1, int px2, int py2, int r2)
        {
            int pDistSquare = ((px1 - px2) * (px1 - px2)) + ((py1 - py2) * (py1 - py2));
            int radiusSumSquare = (r1 + r2) * (r1 + r2);
            return (pDistSquare < radiusSumSquare);
        }
        struct Circle
        {
            public int px, py, r;
            public Circle(int px, int py, int r)
            {
                this.px = px;
                this.py = py;
                this.r = r;
            }
        }
        static void Main(string[] args)
        {
            int myX, myY, nDevice;
            string[] tempArr;
            tempArr = Console.ReadLine().Split(" ");
            myX = int.Parse(tempArr[0]);
            myY = int.Parse(tempArr[1]);
            nDevice = int.Parse(tempArr[2]);
            List<Circle> devices = new List<Circle>();
            for(int x=0; x < nDevice; x++)
            {
                tempArr = Console.ReadLine().Split(" ");
                devices.Add(new Circle(int.Parse(tempArr[0]), int.Parse(tempArr[1]), int.Parse(tempArr[2])));
            }
            //incremental radius
            int myR = 0,countDevice;
            bool breaker = false;
            while (!breaker)
            {
                myR++;
                countDevice = 0;
                for(int i = 0; i < devices.Count; i++)
                {
                    bool isIntersect = checkCirclesIntersection(myX, myY, myR, devices[i].px, devices[i].py, devices[i].r);
                    if (isIntersect) { countDevice++; }
                }
                if(countDevice >2) { breaker = true; }
            }
            Console.WriteLine("{0}",myR-1);
        }
    }
}
