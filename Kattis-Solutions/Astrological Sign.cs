using System;

namespace Astrological_Sign
{
    class Program
    {
        class Sign
        {
            public string signName { get; set; }
            public string startMonth { get; set; }
            public string endMonth { get; set; }
            public int startDate { get; set; }
            public int endDate { get; set; }
            public Sign(int sd, int ed, string sm, string em, string sn) 
            {
                this.signName = sn;
                this.startDate = sd;
                this.endDate = ed;
                this.startMonth = sm;
                this.endMonth = em;
            }
            public bool Check(int date, string month)
            {
                if (!month.Equals(startMonth)&& !month.Equals(endMonth)) { return false; }
                if((month.Equals(startMonth) && date>= startDate) || (month.Equals(endMonth) && date <= endDate)) 
                {
                    return true;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            Sign[] signs = new Sign[]
            {
                new Sign(21,20,"Mar","Apr","Aries"),
                new Sign(21,20,"Apr","May","Taurus"),
                new Sign(21,21,"May","Jun","Gemini"),
                new Sign(22,22,"Jun","Jul","Cancer"),
                new Sign(23,22,"Jul","Aug","Leo"),
                new Sign(23,21,"Aug","Sep","Virgo"),
                new Sign(22,22,"Sep","Oct","Libra"),
                new Sign(23,22,"Oct","Nov","Scorpio"),
                new Sign(23,21,"Nov","Dec","Sagittarius"),
                new Sign(22,20,"Dec","Jan","Capricorn"),
                new Sign(21,19,"Jan","Feb","Aquarius"),
                new Sign(20,20,"Feb","Mar","Pisces"),
            };

            int nq = int.Parse(Console.ReadLine());
            string[] sarr;
            int j;
            bool found;
            string result="";
            for(int i = 0; i < nq; i++) 
            {
                sarr = Console.ReadLine().Split(' ');
                j = 0;
                found = false;
                while (j < signs.Length&&!found)
                {
                    if (signs[j].Check(int.Parse(sarr[0]), sarr[1]))
                    {
                        result = signs[j].signName;
                        found = true;
                    }
                    j++;
                }
                Console.WriteLine(result);
            }
        }
    }
}
