#include <bits/stdc++.h>
#define pb push_back
using namespace std;
struct point{int x,y;};
bool ceksinggung(point a, point b)
{
	if(a.x==b.x||a.y==b.y||(a.x+a.y)==(b.x+b.y)||(a.x-a.y)==(b.x-b.y)||(a.y-a.x)==(b.y-b.x))
	{return true;}
	else{return false;}
}
int main() {
	point temp;
	int sz;
	cin>>sz;
	vector<point> v;
	for(int i=0;i<sz;i++)
	{
		cin>>temp.x>>temp.y;
		v.pb(temp);
	}
	bool truth=true;
	for(int i=0;i<sz;i++)
	{
		for(int j=0;j<sz;j++)
		{
			if(i!=j&&ceksinggung(v[i],v[j])){truth=false;break;}	
		}
	}
	if(truth){cout<<"CORRECT\n";}else{cout<<"INCORRECT\n";}
	return 0;
}
