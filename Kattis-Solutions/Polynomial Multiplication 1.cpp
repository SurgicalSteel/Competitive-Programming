#include <bits/stdc++.h>
using namespace std;
vector<int> solve(vector<int> a,vector<int> b)
{
	vector<int> res;
	int dim=a.size()+b.size()-1;
	int mat[dim][dim];
	for(int i=0;i<dim;i++){
		for(int j=0;j<dim;j++){
			mat[i][j]=0;}}
	if(a.size()>b.size())
	{
		int sta=0,stb=0;
		while(stb<b.size())
		{
			sta=0;
			while(sta<a.size())
			{
				mat[stb][sta+stb]+=(a[sta]*b[stb]);	
				sta++;
			}
			stb++;
		}
	}
	else
	{
		int sta=0,stb=0;
		while(sta<a.size())
		{
			stb=0;
			while(stb<b.size())
			{
				mat[sta][sta+stb]+=(a[sta]*b[stb]);	
				stb++;
			}
			sta++;
		}
	}
	for(int j=0;j<dim;j++){
		int tmp=0;
		for(int i=0;i<dim;i++){
		tmp+=(mat[i][j]);
		}
		res.push_back(tmp);
	}
	return res;
}
int main() {
	int tc,pa,pb,temp;
	scanf("%d",&tc);
	for(int i=0;i<tc;i++)
	{
		vector<int> va,vb,vres;
		scanf("%d",&pa);
		for(int x=0;x<=pa;x++)
		{scanf("%d",&temp);va.push_back(temp);}
		scanf("%d",&pb);
		for(int x=0;x<=pb;x++)
		{scanf("%d",&temp);vb.push_back(temp);}
		vres=solve(va,vb);
		printf("%d\n",vres.size()-1);
		for(int x=0;x<vres.size();x++){printf("%d ",vres[x]);}
		printf("\n");
	}
	return 0;
}
