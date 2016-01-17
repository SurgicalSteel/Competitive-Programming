#include <bits/stdc++.h>
#include <utility>
#include <complex>
#include <tuple>
#include <iostream>
#define pb push_back
#define mp make_pair
using namespace std;
bool isprime(int a) {
	if(a==1){return false;}
    for (int i=2;i*i<=a;i++)
        if(a%i==0)
            return false;
    return true;
}
struct pas{int first;int second;};
int main() {
	int tc,tmp;
	pas ptemp;
	cin>>tc;
	for(int i=0;i<tc;i++)
	{
		cin>>tmp;
		vector<pas> vp;
		for(int x=2;x<=tmp;x++)
		{
			if(isprime(x)&&isprime(tmp-x)&&x<=(tmp-x))
			{
				ptemp.first=x;
				ptemp.second=tmp-x;
				vp.pb(ptemp);
			}
		}
		cout<<tmp<<" has "<<vp.size()<<" representation(s)\n";
		for(int j=0;j<vp.size();j++){cout<<vp[j].first<<"+"<<vp[j].second<<"\n";}
	}
	return 0;
}
