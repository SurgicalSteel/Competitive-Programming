#include <bits/stdc++.h>
using namespace std;
#define psb push_back
int main() {
	string s;
	cin>>s;
	if(s.length()==1){cout<<s<<"\n";}
	else
	{
		stack<string> ss;
		for(int i=0;i<s.length();++i)
		{
			if(s.substr(i,1)!="<"){ss.push(s.substr(i,1));}
			else{ss.pop();}
		}
		vector<string> vs;
		while(!ss.empty())
		{
			vs.psb(ss.top());
			ss.pop();
		}
		for(int i=vs.size()-1;i>=0;--i){cout<<vs[i];}
		printf("\n");
	}
	return 0;
}
