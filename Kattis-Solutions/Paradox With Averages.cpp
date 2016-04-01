#include <bits/stdc++.h>
#define psb push_back
using namespace std;
int main() {
	int tc,ncs,nec;
	float temp,totcs,totec;
	scanf("%d",&tc);
	while(tc--){
		totcs=0;
		totec=0;
		scanf("%d %d",&ncs,&nec);
		float avcs, avec;
		vector<float> vcs,vec;
		for(int i=0;i<ncs;++i)
		{scanf("%f",&temp);vcs.psb(temp);totcs+=temp;}
		avcs=totcs/ncs;
		//printf("%.2f\n",avcs);
		for(int i=0;i<nec;++i)
		{scanf("%f",&temp);vec.psb(temp);totec+=temp;}
		avec=totec/nec;
		//printf("%.2f\n",avec);
		sort(vcs.begin(),vcs.end());
		int counter=0;
		int x=0;
		while(x<ncs)
		{
			float avrescs=(totcs-vcs[x])/(ncs-1);
			//printf("avrescs %.2f\n",avrescs);
			float avresec=(totec+vcs[x])/(nec+1);
			//printf("avresec %.2f\n",avresec);
			if(avrescs>avcs&&avresec>avec){counter++;}
			x++;
		}
		printf("%d\n",counter);
	}
	return 0;
}
