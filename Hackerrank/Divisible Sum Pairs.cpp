#include <bits/stdc++.h>
#define psb push_back
using namespace std;
int main() {
    int n,k,t,ctr=0;
    vector<int> vi;
    scanf("%d %d",&n,&k);
    for(int i=0;i<n;i++)
    {
        scanf("%d",&t);
        vi.psb(t);
    }
    for(int i=0;i<n-1;i++)
    {
        for(int j=1;j<n;j++)
        {
            if(i!=j&&i<j&&(vi[i]+vi[j])%k==0)
            {
                ctr++;
            }    
        }
    }
    printf("%d\n",ctr);
    return 0;
}
