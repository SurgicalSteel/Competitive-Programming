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
    int n,ctr=0;
    bool win;
    string s;
    cin>>n;
    for(int i=0;i<n;++i){
        cin>>s;
        win=true;
        int j=0;
        while(j<(s.length()-1)&&win){
            if(s.substr(j,1)=="C" && s.substr(j+1,1)=="D"){
                win=false;
            }else{
                j++;
            }
            
        }
        if (win){ctr++;}
    }
    cout<<ctr<<"\n";
    return 0;
}
