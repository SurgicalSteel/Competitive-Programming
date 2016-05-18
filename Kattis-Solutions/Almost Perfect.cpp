//template provided by SurgicalSteel a.k.a Yuwono Bangun Nagoro
#include <bits/stdc++.h>
#define psb push_back
using namespace std;
long long int absolutey(long long int x)
{
	if(x>0){return x;}
	else{return x*-1;}
}
int main()
{
	int x;
	long long int res=0,a=0;
	while(cin>>x)
	{
		vector<long long int> v;
		for(int i=1;i<=sqrt(x);++i)
		{
			if(i==1){v.psb(i);}
			else if(x%i==0&&(x/i)!=i){v.psb(i);v.psb(x/i);}
			else if(x%i==0&&(x/i)==i){v.psb(i);}
		}
		res=0;
		a=0;
		for(int i=0;i<v.size();++i){res+=v[i];}
		a=res-x;
		if(res==x){printf("%d perfect\n",x);}
		else if(absolutey(a)<=2){printf("%d almost perfect\n",x);}
		else{printf("%d not perfect\n",x);}
	}
    return 0;
}
