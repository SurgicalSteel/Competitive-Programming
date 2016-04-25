#include <bits/stdc++.h>
using namespace std;
#define psb push_back
int main() {
	int tc;
	scanf("%d",&tc);
	while(tc--)
	{
		char inp[10000];
		scanf("%s",&inp);
		if(strlen(inp)%2!=0){printf("-1\n");}
		else
		{
			int half=strlen(inp)/2;
			int hasha[26],hashb[26];
			for(int i=0;i<26;++i)
			{
				hasha[i]=0;
				hashb[i]=0;
			}
			for(int i=0;i<half;++i)
			{
				hasha[inp[i]-97]++;
				hashb[inp[i+half]-97]++;
			}
			int ctr=0;
			for(int i=0;i<26;++i)
			{ctr+=(abs(hasha[i]-hashb[i]));}
			ctr=ctr/2;
			printf("%d\n",ctr);
		}
		
	}
	return 0;
}
