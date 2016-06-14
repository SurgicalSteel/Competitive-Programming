#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI 3.1415926535897932384626433832795
#define MOD 1000000007
char toCharSingle(string x)
{
  char a[1];
  strncpy(a,x.c_str(),sizeof(a));
  return a[0];
}
int main() {
	// your code goes here
	int len;
	string sa,sb;
	int hasha[26],hashb[26];
	memset(hasha,0,sizeof(hasha));
	memset(hashb,0,sizeof(hashb));
	cin>>len>>sa>>sb;
	int rres=0,sres=0;
	for(int i=0;i<len;++i)
	{
		if(sa.substr(i,1)==sb.substr(i,1))
		{rres++;}
		else
		{
			hasha[toCharSingle(sa.substr(i,1))-65]++;
			hashb[toCharSingle(sb.substr(i,1))-65]++;
		}
	}
	for(int i=0;i<26;++i)
	{sres+=(min(hasha[i],hashb[i]));}
	printf("%d %d\n",rres,sres);
	return 0;
}
