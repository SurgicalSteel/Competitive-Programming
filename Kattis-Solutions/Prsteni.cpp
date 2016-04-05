#include <bits/stdc++.h>
#define psb push_back
using namespace std;
int gcd(int a,int b)
{
	bool found=false;
	int i=min(a,b);
	while(!found&&i>=1)
	{
		if(a%i==0&&b%i==0){found=true;}
		else{i--;}
	}
	return i;
}
int main() {
	int n,temp,g;
	vector<int> v;
	scanf("%d",&n);
	for(int i=0;i<n;++i)
	{
		scanf("%d",&temp);
		if(i==0){v.psb(temp);}
		else
		{
			g=gcd(v[0],temp);
			printf("%d/%d\n",v[0]/g,temp/g);
		}
	}
	return 0;
}
