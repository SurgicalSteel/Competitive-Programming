#include <bits/stdc++.h>
using namespace std;
int main() {
    int n,t,sz,mi=1000000;
    scanf("%d",&n);
    int hlast[100000];
    memset(hlast,-1,sizeof(hlast));
    for(int i=0;i<n;i++)
    {
        scanf("%d",&t);
        if(hlast[t]!=-1)
        {
            mi=min(mi,abs(hlast[t]-i));
            hlast[t]=i;
        }
        else{hlast[t]=i;}
    }
    if(mi==1000000){printf("-1\n");}else{printf("%d\n",mi);}
    return 0;
}
