#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
int toint(string x)
{
    istringstream ss(x);
    int a;
    ss>>a;
    return a;
}
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
void precalc(){

}
bool compare(int a, int b){
    return a>b;
}
int main() {
    // your code goes here
    int n,t,maxi=0;
    vector<int> v;
    cin>>n;
    for(int i=0;i<n;i++){
        cin>>t;
        v.psb(t);
    }
    sort(all(v),compare);
    for(int i=0;i<n;i++){
        maxi = max(maxi, (v[i]+i+1));
    }
    cout<<maxi+1<<"\n";
    return 0;
}
