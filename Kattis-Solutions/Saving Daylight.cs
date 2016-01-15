using System;

public class Test
{
    public static void Main()
    {
        string st=Console.ReadLine();
        while(!string.IsNullOrEmpty(st))
        {
            string build="";
            string[] sar=st.Split();
            build+=(sar[0]+" "+sar[1]+" "+sar[2]+" ");
            int ha,hb,ma,mb,hres,mres;
            string[] sa=sar[3].Split(':');
            string[] sb=sar[4].Split(':');
            ha=int.Parse(sa[0]);
            ma=int.Parse(sa[1]);
            hb=int.Parse(sb[0]);
            mb=int.Parse(sb[1]);
            if(mb-ma<0)
            {
                mb+=60;
                hb--;
            }
            hres=hb-ha;
            mres=mb-ma;
            build+=hres.ToString()+" hours "+mres.ToString()+" minutes";
            Console.WriteLine(build);
            st=Console.ReadLine();
        }
    }
} 
