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
    int ntc,a,b,c;
    bool pos;
    cin>>ntc;
    for(int i=0;i<ntc;i++){
        cin>>a>>b>>c;
        pos=false;
        if ((abs(a-b)==c) || ((a-b) == c) || ((b-a)==c)){
            pos=true;
        }
        if ((a*b)==c){
            pos=true;
        }
        if (((a*c)==b) || ((b*c) == a)){
            pos=true;
        }
        if ((a+b)==c){
            pos=true;
        }
        if (pos){
            cout<<"Possible\n";
        }else{
            cout<<"Impossible\n";
        }
    }
    return 0;
}
