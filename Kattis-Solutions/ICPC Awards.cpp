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
    string id,name;
    int all,ctr=0,idx=0;
    cin>>all;
    vector<pair<string, string> > vpss;
    map<string,string> mss;
    for(int i=0;i<all;i++){
        cin>>id>>name;
        vpss.psb(mkp(id,name));
    }
    map<string,string>::iterator it;
    while(ctr<12 && idx< vpss.size()){
        it=mss.find(vpss[idx].first);
        if (it == mss.end()){
            cout<<vpss[idx].first<<" "<<vpss[idx].second<<"\n";
            mss.insert(mkp(vpss[idx].first,vpss[idx].second));
            ctr++;
        }
        idx++;
    }
    return 0;
}
