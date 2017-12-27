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
void precalc(){

}

int main() {
    // your code goes here
    int q,m,t=0,tot;
    cin>>q>>m;
    for(int i=0;i<m;i++){
        cin>>t;
        if(i==0){
            tot = q-t;
        }else{
            tot +=q;
            tot -=t;
        }
    }
    cout<<tot+q<<"\n";
    return 0;
}
