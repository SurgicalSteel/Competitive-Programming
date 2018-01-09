using System;
using System.Linq;
using System.Collections.Generic;					
public class Program
{
	static string getreal(string s){
		string[] r = s.Split();
		return r[r.Length-1];
	}	
	public static void Main()
	{
		int tc=int.Parse(Console.ReadLine());
		int counter=1;
		string ts;
		while(tc>0)
		{
			Dictionary<string,int> d = new Dictionary<string,int>();
			for(int i=0;i<tc;i++)
			{
				ts=getreal(Console.ReadLine());
				ts= ts.ToLower();
				if (d.ContainsKey(ts))
				{
					d[ts]++;
				}else{
					d[ts]=1;
				}
			}
			var sortedkey = d.Keys.ToList();
			sortedkey.Sort();
			Console.WriteLine("List {0}:",counter);
			foreach (var key in sortedkey)
			{
				Console.WriteLine("{0} | {1}",key,d[key]);
			} 
			counter++;
			tc=int.Parse(Console.ReadLine());
		}
	}
}
