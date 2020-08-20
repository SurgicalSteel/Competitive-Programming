#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n,t,m,r;
    vector<int> v;
    scanf("%d",&n);
    for(int i=0;i<n;i++){
        scanf("%d",&t);
        m = min(m,t);
        v.push_back(t);
    }
    for(int i=0;i<n;i++){
        if(v[i]==m){
            r=i;
            break;
        }
    }
    printf("%d",r);
    return 0;
}
