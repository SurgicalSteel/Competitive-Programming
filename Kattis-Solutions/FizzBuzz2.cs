using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Answer
    {
        private int _index;
        private int _score;
        private string[] sarr;

        public Answer(string[] sarr, int index)
        {
            this.sarr = sarr;
            _index = index;
            _score = 0;
        }

        public void CalculateScore(string[] rans) 
        {
            int s = 0;
            for(int i = 0; i < rans.Length; i++) 
            {
                if (rans[i].Equals(sarr[i])) { s++; }
            }
            _score = s;
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
    }

   

    class Program
    {
        static string[] generateFB(int n)
        {
            string fb = "fizzbuzz";
            string f = "fizz";
            string b = "buzz";
            string[] resfb = new string[n];
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) { resfb[i - 1] = fb; } 
                else if (i % 3 == 0){ resfb[i - 1] = f; }
                else if (i % 5 == 0) { resfb[i - 1] = b; }
                else { resfb[i - 1] = i.ToString(); }
            }
            return resfb;
        }

        static void Main(string[] args)
        {
            string[] sarr;
            sarr = Console.ReadLine().Split(' ');
            int np = int.Parse(sarr[0]), len = int.Parse(sarr[1]);
            string[] comp = generateFB(len);
            List<Answer> lans = new List<Answer>();
            Answer ans;
            for (int x = 0; x < np; x++) 
            {
                sarr = Console.ReadLine().Split(' ');
                ans = new Answer(sarr, x + 1);
                ans.CalculateScore(comp);
                lans.Add(ans);
            }
            
            List<Answer> sorted = lans.OrderByDescending(x => x.Score).ThenBy(x => x.Index).ToList();
            Console.WriteLine(sorted[0].Index);
        }
    }
}
