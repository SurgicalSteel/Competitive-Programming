#include <bits/stdc++.h>
#include <algorithm>
using namespace std;
vector<int> num;
int main() {
	int n,k,iter=0,currprime,finalidx;
	scanf("%d %d",&n,&k);
	for(int i=1;i<n;i++)
	{num.push_back(i+1);}
	int batas=num.size();
	int i=0;
	while(iter<k)
	{
		i=0;
		bool stop=false;
		while(i<batas&&!stop)
		{
			if(num[i]!=-1){currprime=num[i];iter++;stop=true;}
			else{i++;}
		}
		if(iter==k){finalidx=num[i];break;}
		num[i]=-1;
		while(i<batas)
		{
			if(num[i]>0&&num[i]%currprime==0)
			{
				iter++;
				if(iter==k){finalidx=num[i];break;}
				num[i]=-1;
			}
			else{i+=currprime;}
		}
	}
	printf("%d\n",finalidx);
	return 0;
}
