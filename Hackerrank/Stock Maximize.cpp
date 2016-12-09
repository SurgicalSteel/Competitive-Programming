#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
#define psb push_back
int main() {
    int tc,sz,t,ct,x;
    lli tot;
    bool ends;
    scanf("%d",&tc);
    for(int i=0;i<tc;i++){
        scanf("%d",&sz);
        tot=0;
        int tarr[sz];
        for(int j=0;j<sz;j++){
            scanf("%d",&tarr[j]);
        }
        ct=sz-1;
        x=sz-1;
        ends=false;
        while(!ends){
            if(tarr[ct]>tarr[x]&&x>=0){
                tot+=(tarr[ct]-tarr[x]);
            }
            else if(tarr[ct]<=tarr[x]&&x>=0){
                ct=x;
            }
            x--;
            if(x<0){ends=true;}
        }
        printf("%lld\n",tot);
    }
    return 0;
}
