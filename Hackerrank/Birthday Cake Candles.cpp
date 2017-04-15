#include <bits/stdc++.h>
using namespace std;
#define psb push_back

int main() {
    int nc,t,mx=-1999999999,res=0;
    vector<int> v;
    cin>>nc;
    for(int i=0;i<nc;i++){
        cin>>t;
        mx=max(t,mx);
        v.psb(t);
    }
    for(int i=0;i<nc;i++){
        if (v[i]==mx){
            res++;
        }
    }
    cout<<res<<"\n";
    return 0;
}
