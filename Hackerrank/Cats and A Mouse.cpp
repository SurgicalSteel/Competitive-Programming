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
    int tc,pa,pb,pc;
    cin>>tc;
    while(tc--){
        cin>>pa>>pb>>pc;
        if(abs(pa-pc)==abs(pb-pc)){
            cout<<"Mouse C\n";
        }else if (abs(pa-pc)<abs(pb-pc)){
            cout<<"Cat A\n";
        }else if (abs(pa-pc)>abs(pb-pc)){
            cout<<"Cat B\n";
        }
    }
	return 0;
}
