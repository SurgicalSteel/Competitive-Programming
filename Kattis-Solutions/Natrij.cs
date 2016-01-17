using System;

public class Test
{
	public static void Main()
	{
		string[] aw=Console.ReadLine().Split(':');
            string[] ak=Console.ReadLine().Split(':');
            int[] naw = new int[3];
            int[] nak = new int[3];
            int j, m, d;
            for (int i = 0; i < 3; i++)
            {
                naw[i] = int.Parse(aw[i]);
                nak[i] = int.Parse(ak[i]);
            }
            if(nak[0]==naw[0]&&nak[1]==naw[1]&&nak[2]==naw[2])
            {Console.WriteLine("24:00:00");}
            else
            {
	            if (naw[0] > nak[0])
	            {nak[0] += 24;}
	            d = nak[2] - naw[2];
	            if (d < 0)
	            {
	                d += 60;
	                nak[1]--;
	            }
	            m = nak[1] - naw[1];
	            if (m < 0)
	            {
	                m += 60;
	                nak[0]--;
	            }
	            j = nak[0] - naw[0];
	            string sj, sm, sd;
	            if (j < 10)
	            {sj = "0" + j.ToString();}
	            else
	            {sj = j.ToString();}
	            if (m < 10)
	            {sm = "0" + m.ToString();}
	            else
	            {sm = m.ToString();}
	            if (d < 10)
	            {sd = "0" + d.ToString();}
	            else
	            {sd = d.ToString();}
	            Console.WriteLine(sj + ":" + sm + ":" + sd);
            }
	}
}
