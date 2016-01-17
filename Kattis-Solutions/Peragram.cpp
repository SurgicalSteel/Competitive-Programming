#include <bits/stdc++.h>
using namespace std;
char toCharSingle(string x)//single substring as input. Converts single substring to single char
{
  char a[1];
  strncpy(a,x.c_str(),sizeof(a));
  return a[0];
}
int main() {
	int hash[26];
	for(int i=0;i<26;i++){hash[i]=0;}
	string s;
	cin>>s;
	int l=s.length();
	for(int i=0;i<l;i++)
	{
		char c=toCharSingle(s.substr(i,1));
		hash[c-97]++;
	}
	// begin count ganjil
	int gjl=0;
	for(int i=0;i<26;i++)
	{
		if(hash[i]%2!=0){gjl++;}
	}
	// end count ganjil
	if(gjl<=1){cout<<0<<"\n";}else {cout<<gjl-1<<"\n";}
	return 0;
}
