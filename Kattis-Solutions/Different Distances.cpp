#include <bits/stdc++.h>
using namespace std;
int main() {
	float xa,ya,xb,yb,p,res;
	while(cin>>xa>>ya>>xb>>yb>>p)
	{
		res=pow((pow(abs(xa-xb),p)+pow(abs(ya-yb),p)),1/p);
		//printf("%.1f %.1f %.1f %.1f %.1f\n",xa,ya,xb,yb,p);
		printf("%.10f\n",res);
	}
	return 0;
}
