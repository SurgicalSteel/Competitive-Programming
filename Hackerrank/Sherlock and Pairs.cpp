#include <bits/stdc++.h>
#include <algorithm>
#define psb push_back
using namespace std;
int main() {
    int tc,sz,tmp;
    scanf("%d",&tc);
    int num[1000001]={0};
    long long int tot,r;
    for(int i=0;i<tc;i++)
    {
        tot=0;
        //memset(num,0,sizeof(num));
        scanf("%d",&sz);
        for(int y=0;y<sz;y++)
        {
            scanf("%d",&tmp);
            num[tmp]++;
        }        
        for(int x=0;x<=1000000;x++)
        {
            if(num[x]>1)
            {
                r=num[x];
                tot+=(r*(r-1));
            }/*((ctr[x]*(ctr[x]-1))/2)*/
            num[x]=0;
        }
        printf("%lld\n",tot);
    }
    return 0;
}
