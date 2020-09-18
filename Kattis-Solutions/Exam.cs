using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCorrect = int.Parse(Console.ReadLine());
            string mine = Console.ReadLine();
            string friend = Console.ReadLine();

            int diff = 0, same, tot = mine.Length, res;
            for (int i = 0; i < mine.Length; i++)
            {
                if (mine.Substring(i, 1) != friend.Substring(i, 1)) { diff++; }
            }
            same = tot - diff;
            if (same == 0)
            {
                res = tot - nCorrect;
                Console.WriteLine("{0}", res);
                return;
            }
            if (same == tot)
            {
                res = nCorrect;
                Console.WriteLine("{0}", res);
                return;
            }
            if (same >= nCorrect)
            {
                res = nCorrect + diff;
            }
            else
            {
                res = same + diff - (nCorrect-same);
            }
            Console.WriteLine("{0}", res);
        }
    }
}
