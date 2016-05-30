#include <bits/stdc++.h>
using namespace std;
#define PI 3.141592654
int main() {
	float r,m,c,resa,resb;
	cin>>r>>m>>c;
	while(r!=0&&m!=0&&c!=0)
	{
		resa=PI*r*r;
		resb=4*c/m*r*r;
		cout<<setprecision(10)<<resa<<" "<<resb<<"\n";
		cin>>r>>m>>c;
	}
	return 0;
}
