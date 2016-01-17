#include <bits/stdc++.h>
#include <vector>
#include <algorithm>
using namespace std;
#define pb push_back
int solve(vector <int> big, int szbig, vector <int> small, int szsmall)
{
	sort(big.begin(),big.end());
	sort(small.begin(),small.end());
	bool sama=true;
	int i=0,res;
	while(sama&&i<small.size())
	{
		if(big[i]!=small[i])
		{
			res=big[i];
			sama=false;
		}
		if(i+1==small.size()&&sama)
		{
			res=big[i+1];
			sama=false;
		}
		i++;
	}
	return res;
}
int main() {
	// your code goes here
	int n,x;
	vector <int> a,b,c;
	cin>>n;
	for(int i=0;i<n;i++)
	{
		cin>>x;
		a.pb(x);
	}
	for(int i=0;i<n-1;i++)
	{
		cin>>x;
		b.pb(x);
	}
	for(int i=0;i<n-2;i++)
	{
		cin>>x;
		c.pb(x);
	}
	cout<<solve(a,a.size(),b,b.size())<<"\n";
	cout<<solve(b,b.size(),c,c.size())<<"\n";
	return 0;
}
