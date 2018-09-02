#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007

int main() {
    // your code goes here
    int idx,nt,temp,nb,sc,possb,pvhm;
    vector<int> pt,pb,ptb;
    cin>>nt;
    
    for(int i=0;i<nt;i++){
        cin>>temp;
        pt.psb(temp);
    }
    cin>>nb;
    for(int i=0;i<nb;i++){
        cin>>temp;
        pb.psb(temp);
    }
    for(int i=0;i<nt;i++){
        cin>>possb;
        for(int j=0;j<possb;j++){
            cin>>temp;
            ptb.psb(pb[temp-1]+pt[i]);
        }
    }
    cin>>pvhm;
    sort(all(ptb));
    sc=(pvhm - (pvhm%ptb[0]))/ptb[0];
    cout<<max(sc-1,0)<<"\n";
    return 0;
}
