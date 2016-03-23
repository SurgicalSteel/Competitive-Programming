#include <bits/stdc++.h>
#include <algorithm>
using namespace std;
//Sieve of Eratosthenes
//Created by Yuwono Bangun Nagoro a.k.a SurgicalSteel
int main()
{
	int num,first=0;
	scanf("%d",&num);
	vector<int> v;
	for(int i=0;i<num-1;++i)
	{v.push_back(i+2);}
	int check=0,ptr=0;
	while(check<v.size())
	{
		while(ptr<v.size())
		{
			if(v[ptr]!=-1)
			{
				check++;
				for(int i=ptr;i<v.size();++i)
				{if(v[i]!=-1&&v[i]%v[ptr]==0&&i!=ptr){v[i]=-1;check++;}}
			}
			ptr++;
		}
	}	
	for(int i=0;i<v.size();i++)
	{if(v[i]!=-1){printf("%d\n",v[i]);}}
    return 0;
}
