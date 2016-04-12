#include <bits/stdc++.h>
#define psb push_back
using namespace std;
struct daydate{
	int date;
	string day;
	};
int main() {
	int tc,nd,nm,ndm;
	daydate tempdd;
	string tempday;
	scanf("%d",&tc);
	for(int w=0;w<tc;++w)
	{
		vector<daydate> vdd;
		scanf("%d %d",&nd,&nm);
		for(int x=0;x<nd;++x)
		{
			if(x%7==0){tempday="sun";}else
			if(x%7==1){tempday="mon";}else
			if(x%7==2){tempday="tue";}else
			if(x%7==3){tempday="wed";}else
			if(x%7==4){tempday="thu";}else
			if(x%7==5){tempday="fri";}else
			if(x%7==6){tempday="sat";}
			tempdd.day=tempday;
			tempdd.date=0;
			vdd.psb(tempdd);
		}
		int accum=0,ctr=0;
		for(int x=0;x<nm;++x)
		{
			scanf("%d",&ndm);
			int start=1;
			for(int id=accum;id<ndm+accum;++id)
			{
				vdd[id].date=start;start++;
				//cout<<vdd[id].date<<vdd[id].day<<"\n";
				if(vdd[id].date==13&&vdd[id].day=="fri"){ctr++;}
			}
			accum+=ndm;
			//cout<<"\n";
		}
		printf("%d\n",ctr);
	}
	return 0;
}
