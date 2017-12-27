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
int main() {
    // your code goes here
    int nall,nec,t,sec,caav;
    vector<int> v;
    double avec,prec;   
    cin>>nall;
    for(int i=0;i<nall;i++){
    cin>>nec;
        v.clear();
        sec=0;
        caav=0;
        prec=0;
        for(int j=0;j<nec;j++){
            cin>>t;
            v.psb(t);
            sec+=t;     
    }
        avec= double(sec);
        avec /= double(nec);
        for(int k=0;k<v.size();k++){
            if(double(v[k])>avec){
                caav++;
            }
        }
        //cout<<caav<<" ------------ "<<v.size()<<"\n";
        prec=100*double(caav)/double(v.size());
        printf("%.3f%\n",prec);
    }
    return 0;
}
