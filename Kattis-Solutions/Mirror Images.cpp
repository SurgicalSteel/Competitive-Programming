#include <bits/stdc++.h>
using namespace std;

int main() {
	int tc,r,c,temp;
	scanf("%d",&tc);
	for(int it=0;it<tc;it++)
	{
		scanf("%d %d",&r,&c);
		char img[r][c];
		for(int ir=0;ir<r;ir++)
		{cin>>img[ir];}
		cout<<"Test "<<it+1<<"\n";
		for(int ir=0;ir<r;ir++)
		{
			for(int ic=0;ic<c;ic++)
			{
				cout<<img[r-ir-1][c-ic-1];
			}
			cout<<"\n";
		}
	}
	return 0;
}
