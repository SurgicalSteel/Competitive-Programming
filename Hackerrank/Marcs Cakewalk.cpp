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
lli pwr(int base,int exp)
{
    if(exp==0){return 1;}
    else{return base*pwr(base,exp-1);}
}
bool comp(int a, int b){return a>b;}
int main() {
	// your code goes here
	int nc,temp;
    vector<int> v;
    cin>>nc;
    for(int i=0;i<nc;i++){
        cin>>temp;
        v.psb(temp);
    }
    lli r=0;
    sort(all(v),comp);
    for(int i=0;i<nc;i++){
        r+=(v[i]*pwr(2,i));
    }
    cout<<r<<"\n";
	return 0;
}
