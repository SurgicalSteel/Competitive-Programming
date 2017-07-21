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
    int nr,d,m,ans=0,t;
    scanf("%d",&nr);
    int r[nr];
    for(int i=0;i<nr;i++){
        scanf("%d",&r[i]);
    }
    scanf("%d %d",&d,&m);
    for(int i=0;i<nr-m+1;i++){
        t=0;
        for(int j=i;j<i+m;j++){
            t+=r[j];
        }
        if(t==d){
            ans++;
        }
    }
    cout<<ans<<"\n";
	return 0;
}
