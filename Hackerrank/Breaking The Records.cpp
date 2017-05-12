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
    int sz,c,mi=0,ma=0,cmi,cma;
    cin>>sz;
    for(int i=0;i<sz;i++){
        cin>>c;
        if (i==0){
            cmi=c;
            cma=c;
        }
        if (i>0){
            if (c<cmi){
                mi++;
                cmi=c;
            }
            if (c>cma){
                ma++;
                cma=c;
            }
        }
    }
    cout<<ma<<" "<<mi<<"\n";
	return 0;
}
