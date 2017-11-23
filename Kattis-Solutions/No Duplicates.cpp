#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
int main() {
	map<string,int>::iterator it;
	string s;
	map<string,int> m;
	bool isex=false;
	while(cin>>s){
		it=m.find(s);
		if(it != m.end()){
			isex=true;
		}
		m[s]=1;
	}
	if (isex){cout<<"no\n";}else{cout<<"yes\n";}
	return 0;
}
