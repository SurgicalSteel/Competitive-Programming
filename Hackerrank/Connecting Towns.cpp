#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
int main() {
    int tc,temp,nc;
    scanf("%d",&tc);
    for(int i=0;i<tc;i++)
    {
        scanf("%d",&nc);
        long long res=1;
        for(int x=0;x<nc-1;x++)
        {
            scanf("%d",&temp);
            res*=temp;
            res=res%1234567;
        }
        printf("%lld\n",res);
    }
    return 0;
}
