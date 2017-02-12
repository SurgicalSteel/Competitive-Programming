#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
string eliminateAt(string x, int num)//eliminates a single substring of a string in a given position
{
    if(num==0){return x.substr(1,x.length()-1);}
    else if(num==x.length()-1){return x.substr(0,x.length()-1);}
    else{return x.substr(0,num)+x.substr(num+1,x.length()-1);}
}
bool isUnique(string s){
	if(s.length()==0){return true;}
	for(int i=0;i<s.length()-1;i++){
		if(s.substr(i,1)==s.substr(i+1,1)){
			return false;
		}
	}
	return true;
}
int main() {
	// your code goes here
	string s;
	int i;
	cin>>s;
	bool unique=false,flagstop;
	while(!unique&&s.length()>0){
		i=0;
		flagstop=false;
		while(i<s.length()&&!flagstop){
			if(s.substr(i,1)==s.substr(i+1,1)){
				s=eliminateAt(s,i);
				s=eliminateAt(s,i);
			}
			else{i++;}
			if(s.length()==0){flagstop=true;}
		}
		unique=isUnique(s);
	}
	if(s.length()==0){cout<<"Empty String\n";}
	else{cout<<s<<"\n";}
	return 0;
}
