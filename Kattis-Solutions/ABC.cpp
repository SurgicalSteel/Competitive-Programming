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
//by Yuwono Bangun Nagoro a.k.a SurgicalSteel
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
int main() {
    // your code goes here
    int x,y,z,mi,md,ma;
    string s;
    cin>>x>>y>>z;
    mi = min(x,min(y,z));
    ma = max(x,max(y,z));
    if((mi==x&&ma==y) || (mi==y&&ma==x)){md=z;}
    if((mi==x&&ma==z) || (mi==z&&ma==x)){md=y;}
    if((mi==z&&ma==y) || (mi==y&&ma==z)){md=x;}
    cin>>s;
    for(int i=0;i<s.length();i++){
        if (s.substr(i,1)=="A"){cout<<mi<<" ";}
        else if (s.substr(i,1)=="B"){cout<<md<<" ";}
        else if (s.substr(i,1)=="C"){cout<<ma<<" ";}
    }
    cout<<"\n";
    return 0;
}
