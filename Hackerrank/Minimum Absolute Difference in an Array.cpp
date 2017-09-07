#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
int toInt(string x)
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
int main() {
    // your code goes here
    vector<int> v;
    int n,t;
    int mini=1000000000;
    scanf("%d",&n);
    for(int i=0;i<n;i++){
        scanf("%d",&t);
        v.psb(t);
    }
    sort(all(v));
    for(int i=0;i<n;i++){
        mini=min(abs(v[i]-v[i+1]),mini);
    }
    printf("%d\n",mini);
    return 0;
}
