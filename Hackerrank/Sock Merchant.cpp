#include <bits/stdc++.h>
using namespace std;
#define psb push_back
int main() {
    int n,x,c=0;
    scanf("%d",&n);
    vector<int> idx,ctr;
    vector<int>::iterator iter;
    int ar[n];
    while(n--)
    {
        scanf("%d",&ar[c]);
        iter = find(idx.begin(),idx.end(),ar[c]);
        if(iter==idx.end())
        {
            idx.psb(ar[c]);
            ctr.psb(1);
        }
        else
        {ctr[distance(idx.begin(),iter)]++;}
    }
    int tot =0;
    for(int it=0;it<ctr.size();it++)
    {tot+= ((ctr[it]-(ctr[it]%2))/2);}
    printf("%d\n",tot);
    return 0;
}
