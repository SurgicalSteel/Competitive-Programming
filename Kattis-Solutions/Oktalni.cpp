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
string octalize(string s){
	int a,b,c;
	a=toInt(s.substr(0,1));
	b=toInt(s.substr(1,1));
	c=toInt(s.substr(2,1));
	return tostr((a*4)+(b*2)+(c*1));
}
int main() {
	// your code goes here
	string i,o,r;
	cin>>i;
	if(i.length()%3!=0){
		for(int x=0;x<i.length()%3;x++){
			i="0"+i;
		}
	}
	//cout<<i<<"\n"; //test
	int idx=i.length()-3;
	while(idx>=0){
		o+=octalize(i.substr(idx,3));
		idx-=3;
	}
	for(int x=o.length()-1;x>=0;x--){
		r+=o.substr(x,1);
	}
	cout<<r<<"\n";
	return 0;
	
}
