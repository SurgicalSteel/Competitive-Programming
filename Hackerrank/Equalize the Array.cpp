#include <bits/stdc++.h>
using namespace std;
int main() {
    int n,t,ma;
    scanf("%d",&n);
    int h[101];
    memset(h,0,sizeof(h));
    for(int i=0;i<n;i++)
    {
        scanf("%d",&t);
        h[t]++;
    }
    for(int i=0;i<101;i++)
    {ma=max(ma,h[i]);}
    printf("%d\n",n-ma);
    return 0;
}
