#include <bits/stdc++.h>
using namespace std;
int main() {
	int tc;
	string a,b,build;
	scanf("%d",&tc);
	while(tc--)
	{
		build="";
		cin>>a>>b;
		for(int i=0;i<a.length();++i)
		{
			if(a.substr(i,1)==b.substr(i,1)){build+=".";}else{build+="*";}
		}
		cout<<a<<"\n"<<b<<"\n"<<build<<"\n";
	}
	return 0;
}
