#include <bits/stdc++.h>
#define psb push_back
using namespace std;
vector<int> vp;
void precompute()
{
    int num=1000000,first=0;
	vector<int> v;
	for(int i=0;i<num-1;++i)
	{v.psb(i+2);}
	int check=0,ptr=0;
	while(check<v.size())
	{
		while(ptr<v.size())
		{
			if(v[ptr]!=-1)
			{
                vp.psb(v[ptr]);
				check++;
				for(int i=ptr;i<v.size();i+=v[ptr])
				{if(v[i]!=-1&&v[i]%v[ptr]==0&&i!=ptr){v[i]=-1;check++;}}
			}
			ptr++;
		}
	}	
}
int main() {
    precompute();
    int tc,temp,x;
    unsigned long long tot;
    scanf("%d",&tc);
    for(int i=0;i<tc;++i){
        tot=0;
        scanf("%d",&temp);
        x=0;
        while(vp[x]<=temp){tot+=vp[x];x++;}
        printf("%llu\n",tot);
    }
    return 0;
}
