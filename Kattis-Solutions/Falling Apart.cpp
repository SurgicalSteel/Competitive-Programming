#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
typedef pair<int, int> pii;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
#define fff first
#define sss second
bool cmp(int i, int j){
    return i>j;
}
int main() {
    // your code goes here
    int n,t,ca=0,cb=0;
    vector<int> v;
    cin>>n;
    for(int i=0;i<n;i++){
        cin>>t;
        v.psb(t);
    }
    sort(all(v),cmp);
    for(int i=0;i<v.size();i++){
        if(i%2==0){
            ca+=v[i];
        }else{
            cb+=v[i];
        }
    }
    cout<<ca<<" "<<cb<<"\n";
    return 0;
}
