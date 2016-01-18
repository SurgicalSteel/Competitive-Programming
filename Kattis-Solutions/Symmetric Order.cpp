#include <bits/stdc++.h>
#define pb push_back
using namespace std;
int main() {
	
	int tc,ctrset=1;
	cin>>tc;
	string tmp;
	while(tc!=0)
	{
		vector<string> vs;
		for(int i=0;i<tc;i++){cin>>tmp;vs.pb(tmp);}
		cout<<"SET "<<ctrset<<"\n";
		for(int i=0;i<tc;i++){if(i%2==0){cout<<vs[i]<<"\n";}}
		for(int i=vs.size()-1;i>=0;i--){if(i%2!=0){cout<<vs[i]<<"\n";}}
		ctrset++;
		cin>>tc;
	}
	return 0;
}
