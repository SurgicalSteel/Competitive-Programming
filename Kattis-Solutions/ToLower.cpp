#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
void precalc() {

}
string low(string inp)
{
    string res;
    locale loc;
    for(string::size_type i=0;i<inp.length();i++){
        res+=tolower(inp[i],loc);
    }
    return res;
}
string psolve(string s){
    string pref=s.substr(0,1);
    string rest="";
    if (s.length()>0){
        rest=s.substr(1,s.length()-1);
    }
    return low(pref)+rest;
}


int main() {
    // your code goes here
    int p,t,pcount=0;
    bool ss;
    string s;
    cin>>p>>t;
    for(int ip=0;ip<p;ip++){
        ss=true;
        for(int it=0;it<t;it++){
            cin>>s;
            ss = (ss && psolve(s)==low(s));
        }
        if (ss){
            pcount++;
        }
    }
    cout<<pcount<<"\n";
 
    return 0;
}
