#include <bits/stdc++.h>
#include <algorithm>
#define psb push_back
using namespace std;
void solve(int  n, int a, int b)
{
    vector<int> res;
    int maxi=max(a,b);
    int mini=min(a,b);
    int mat[n][n-1];
    int sel;
    for(int j=0;j<n;j++)
    {
        int counter=0;
        for(int i=0;i<n-1;i++)
        {
            if(j>0&&i<j){counter+=maxi;}
            else{counter+=mini;}
        }
        res.psb(counter);
    }
    vector<int>::iterator iter=unique(res.begin(),res.end());
    res.resize(distance(res.begin(),iter));
    for(int i=0;i<res.size();i++)
    {printf("%d ",res[i]);}
    printf("\n");
}

int main() {
    int tc, tmn,tma,tmb;
    scanf("%d",&tc);
    for(int i=0;i<tc;i++)
    {
        scanf("%d %d %d",&tmn,&tma,&tmb);
        solve(tmn,tma,tmb);
    }
    return 0;
}
