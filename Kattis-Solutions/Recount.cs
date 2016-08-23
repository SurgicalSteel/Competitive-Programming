using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Test
{
	static int FFIndex(List<string> ls, string x)
	{
		int xa=0;
		for(int i=0;i<ls.Count;i++){if(ls[i].Equals(x)){xa=i;break;}}
		return xa;
	}
	public static void Main()
	{
		List<string> ls=new List<string>();
		List<int> li=new List<int>();
		string stin;
		int ctr=0;
		int jml=0;
		string sementara="";
		bool isrunoff=false;
		stin=Console.ReadLine();
		Dictionary<string,int> d = new Dictionary<string,int>();
		int maxi=0;
		while(!stin.Equals("***"))
		{
			if(d.ContainsKey(stin))
			{d[stin]++;maxi=Math.Max(maxi,d[stin]);}
			else{d.Add(stin,1);maxi=Math.Max(maxi,d[stin]);ctr++;}
			stin=Console.ReadLine();
		}
		foreach (string str in d.Keys)
		{
			if(d[str]==maxi){jml++;sementara=str;}
			if(jml>1){isrunoff=true;break;}
		}
		if(isrunoff){Console.WriteLine("Runoff!");}
		else{Console.WriteLine(sementara);}
	}
}
