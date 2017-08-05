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
    int d,nk,nm,tk,tm,mv=-1;
    vector<int> k,m;
    cin>>d>>nk>>nm;
    for(int i=0;i<nk;i++){
        cin>>tk;
        k.psb(tk);
    }
    for(int i=0;i<nm;i++){
        cin>>tm;
        m.psb(tm);
    }
    for(int i=0;i<nk;i++){
        for(int j=0;j<nm;j++){
            if((k[i]+m[j])>mv&&(k[i]+m[j])<=d){
                mv=(k[i]+m[j]);
            }        
        }
    }
    cout<<mv<<"\n";
	return 0;
}
