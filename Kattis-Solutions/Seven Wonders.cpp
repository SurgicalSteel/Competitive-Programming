#include <bits/stdc++.h>
using namespace std;
int main() {
	string s;
	cin>>s;
	int nt=0,nc=0,ng=0;
	long long int tot;
	for(int i=0;i<s.length();i++)
	{
		if(s.substr(i,1)=="T"){nt++;}
		else if(s.substr(i,1)=="C"){nc++;}
		else if(s.substr(i,1)=="G"){ng++;}
	}
	tot+=((nt*nt)+(nc*nc)+(ng*ng));
	tot+=(min(ng,min(nt,nc)))*7;
	cout<<tot<<"\n";
	return 0;
}
