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
	int bs,br,ba,aa,as,ar,y=0,ats=0;
	cin>>ba>>br>>bs>>aa>>as;
	while(ats<=((br-ba)*bs)){
		ats+=as;
		y++;
	}
	cout<<y+aa<<"\n";
	return 0;
}
