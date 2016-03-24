#include <bits/stdc++.h>
using namespace std;
int main() {
	int szw,whl=1,build=0,step=0,tempwhl;
	scanf("%d",&szw);
	while(whl<szw){whl*=2;}
	tempwhl=whl;
	while(build!=szw)
	{
		if(szw==whl){step=0;build+=whl;}
		else if(step==0&&whl>1)
		{
			build+=(whl/2);
			whl=whl/2;
			step++;
		}
		else if(step==0&&whl==1)
		{
			build++;
			whl=0;
			step++;
		}
		else
		{
			if(build+(whl/2)<=szw)
			{
				build+=(whl/2);
				if(whl>1){whl=whl/2;}
				step++;
			}
			else 
			{
				whl=whl/2;
				step++;
			}
		}
	}
	printf("%d %d\n",tempwhl,step);
	return 0;
}
