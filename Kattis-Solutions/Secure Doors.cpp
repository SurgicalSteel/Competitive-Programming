#include <bits/stdc++.h>
#include <algorithm>
#define pb push_back
using namespace std;
//entered=true, exited=false
vector<string> vname;
vector<bool> vstat;
bool cekada(vector<string> vname, string name)
{
	vector<string>::iterator iter=vname.begin();
	iter=find(vname.begin(),vname.end(),name);
	if(iter==vname.end()){return false;}else{return true;}
}
int findindex(vector<string> vname,string name)
{
	vector<string>::iterator iter=vname.begin();
	iter=find(vname.begin(),vname.end(),name);
	return distance(vname.begin(),iter);
}
string solve(string name, string act)
{
	 if(!cekada(vname,name))
	 {
	 	if(act=="entry")
	 	{
	 		vname.pb(name);
	 		vstat.pb(true);
	 		return name+" entered\n";
	 	}
	 	else
	 	{
	 		vname.pb(name);
	 		vstat.pb(false);
	 		return name+" exited (ANOMALY)\n";
	 	}
	 }
	 else //udah ada
	 {
	 	bool stat=vstat[findindex(vname,name)];
	 	if(act=="entry")
	 	{
	 		if(stat){return name+" entered (ANOMALY)\n";}
	 		else
	 		{
	 			vstat[findindex(vname,name)]=true;
	 			return name+" entered\n";
	 		}
	 	}
	 	else//exit
	 	{
	 		if(stat)
	 		{
	 			vstat[findindex(vname,name)]=false;	
	 			return name+" exited\n";
	 		}
	 		else{return name+" exited (ANOMALY)\n";}
	 	}
	 }
}
int main() {
	
	int tc;
	cin>>tc;
	string s,a;
	for(int i=0;i<tc;i++)
	{
		cin>>a>>s;
		cout<<solve(s,a);
	}
	return 0;
}
