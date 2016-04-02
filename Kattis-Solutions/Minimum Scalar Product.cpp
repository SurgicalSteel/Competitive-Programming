#include <bits/stdc++.h>
#define psb push_back
using namespace std;
int main() {
	int tc,sz,temp,n;
	long long int res;
	scanf("%d",&tc);
	n=tc;
	while(tc--)
	{
		res=0;
		scanf("%d",&sz);
		vector<int> va,vb;
		for(int i=0;i<sz;++i)
		{
			scanf("%d",&temp);
			va.psb(temp);
		}
		for(int i=0;i<sz;++i)
		{
			scanf("%d",&temp);
			vb.psb(temp);
		}
		sort(va.begin(),va.end());
		sort(vb.begin(),vb.end());
		for(int i=0;i<sz;++i)
		{res+=(((long long)va[i])*((long long)vb[sz-i-1]));}
		printf("Case #%d: %lld\n",n-tc,res);
	}
	return 0;
}
