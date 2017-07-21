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
    int b[5],n,t,m=0,d;
    memset(b,0,sizeof(b));
    cin>>n;
    while(n--){
        cin>>t;
        b[t-1]++;
    }
    
    for(int i=4;i>=0;i--){
        if(max(m,b[i])==b[i]){
            d=i;
            m=b[i];
        }
    }
    cout<<d+1<<"\n";
	return 0;
}
