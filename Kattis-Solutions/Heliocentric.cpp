#include <bits/stdc++.h>
using namespace std;

int main() {
	int e,m; // e : 0-364 & m : 0-686
	int cs=1;
	while(cin>>e>>m)
	{
		if(m==0&&e==0){printf("Case %d: 0\n",cs);}
		else
		{
			bool breaker=false;
			int step=0;
			while(!breaker)
			{
				m=(m+1)%687;
				e=(e+1)%365;
				step++;
				if(m==0&&e==0){breaker=true;}
			}
			printf("Case %d: %d\n",cs,step);
		}
		cs++;
	}
	return 0;
}
