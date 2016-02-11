#include <bits/stdc++.h>
#include <algorithm>
using namespace std;
//Sieve of Eratosthenes
//Created by Yuwono Bangun Nagoro a.k.a SurgicalSteel
//Still needs some improvements
int main()
{
	int num,first=0;
	scanf("%d",&num);
	vector<int> v;
	vector<int> vres;
	for(int i=1;i<num;i++)
	{v.push_back(i+1);}
	int cek=0;
	while(cek<v.size())
	{
		bool stop=false;
		first=0;
		while(first<v.size()&&!stop)
		{
			if(v[first]!=-1){stop=true;}
			else{first++;}
		}
		if(v[first]!=-1)
		{
			int temp=v[first];
			vres.push_back(temp);
			v[first]=-1;
			cek++;
			for(int i=first+1;i<v.size();i++)
			{
				if(v[i]!=temp&&v[i]%temp==0&&v[i]!=-1)
				{
					v[i]=-1;
					cek++;
				}
			}
		}
	}
	for(int i=0;i<vres.size();i++)
	{printf("%d\n",vres[i]);}
    return 0;
}
