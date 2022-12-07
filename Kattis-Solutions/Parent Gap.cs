using System;
using System.Collections.Generic;

namespace Parent_Gap
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            List<DateTime> allDate = new List<DateTime>();
            int mds = 0; //mothers day second sunday of may
            int fds = 0; //fathers day third Sunday in June
            int interval=0;
            bool active = false;
            DateTime init = new DateTime(year, 1, 1);
            while (true) 
            {
                allDate.Add(init);

                if(mds>1 && active) { interval++; }
                
                if(init.Month==5 && init.DayOfWeek.ToString()== "Sunday")
                {
                    if(mds==1){ active = true;}
                    mds++;
                }

                if(init.Month==6 && init.DayOfWeek.ToString() == "Sunday")
                {
                    if (fds == 2) { active = false; }
                    fds++;
                }

                init = init.AddDays(1);
                if (init.Year > year) { break; }
            }
            Console.WriteLine("{0} weeks",interval/7);
            //for(int i = 0; i < allDate.Count; i++) { Console.WriteLine("{0}--{1}-{2}-{3} ", allDate[i].DayOfWeek, allDate[i].Day, allDate[i].Month, allDate[i].Year); } //Saturday--31-12-2022 
        }
    }
}
