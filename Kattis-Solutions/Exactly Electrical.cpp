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
    int ax,ay,bx,by,l,sp;
    cin>>ax>>ay>>bx>>by>>l;
    sp=(abs(ax-bx)+abs(ay-by));
    if(l<sp){
        cout<<"N\n";
    }else{
        if ((l-sp)%2==0){
            cout<<"Y\n";
        }else{
            cout<<"N\n";    
        }
    }
    return 0;
}
