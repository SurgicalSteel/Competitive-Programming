#include <bits/stdc++.h>
#include <algorithm>
#define psb push_back
#define mkp make_pair
using namespace std;
const int maxsz=1000;
vector<int> graph[maxsz];
int distarr[maxsz];
int main() {
	int tc,nv,ne,s,ts,td;
	scanf("%d",&tc);
	for(int i=0;i<tc;i++)
	{
		scanf("%d %d",&nv,&ne);
		for(int x=0;x<ne;x++)
		{
			scanf("%d %d",&ts,&td);
			ts--;
			td--;
			graph[ts].psb(td);
			graph[td].psb(ts);
		}
		scanf("%d",&s);
		s--;
		//initialize distance -1 except the starting point s=0
		for(int x=0;x<maxsz;x++)
		{
			if(x==s){distarr[x]=0;}
			else
			{distarr[x]=-1;}
		}
		//start BFS + distance filling
		queue<int> qtemp;
		qtemp.push(s);
		while(!qtemp.empty())
		{
			int parent=qtemp.front();
			qtemp.pop();
			for(int x=0;x<graph[parent].size();x++)
			{
				int neighbor=graph[parent][x];
				if(distarr[neighbor]==-1)
				{
					distarr[neighbor]=distarr[parent]+1;
					qtemp.push(neighbor);
				}
			}
		}
		for(int x=0;x<nv;x++)
		{
			if(x!=s&&distarr[x]==-1)
			{printf("%d ",distarr[x]);}
			else if(x!=s&&distarr[x]>=1)
			{printf("%d ",distarr[x]*6);}
		}
		printf("\n");
		for(int x=0;x<nv;x++){graph[x].clear();}
	}
	return 0;
}
