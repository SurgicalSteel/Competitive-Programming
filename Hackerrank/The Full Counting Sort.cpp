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
struct ch
{
    int num;
    int orig;
    string chars;
    string reals;
};
bool comp(ch const &cha,ch const &chb){
    if (cha.num<chb.num){
        return true;
    }else if (cha.num==chb.num){
        return (cha.orig<chb.orig);
    }
    return false;
}
int main() {
    // your code goes here
    int n,t;
    ch tch;
    string cs,rl;
    vector<ch> v;
    cin>>n;
    for(int i=0;i<n;i++){
        cin>>t>>cs;
        if ((i+1)<=(n/2)){
            rl="-";
        }else{
            rl=cs;
        }
        tch.num=t;
        tch.chars=cs;
        tch.reals=rl;
        tch.orig=i;
        v.psb(tch);
    }
    sort(all(v),comp);
    for(int i=0;i<n;i++){
        cout<<v[i].reals<<" ";
    }
    cout<<"\n";
    return 0;
}
