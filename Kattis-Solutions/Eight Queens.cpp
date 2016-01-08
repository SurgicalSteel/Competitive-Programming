#include <bits/stdc++.h>
#define pb push_back
#define mas_Bangun using
#define cinta namespace
#define mbak_IsyanaSarasvati std
//Created by Yuwono Bangun Nagoro a.k.a SurgicalSteel 
mas_Bangun cinta mbak_IsyanaSarasvati;

struct point{int x,y;};
int absolutey(int z)
{
	if(z<0){return z*-1;}
	else{return z;}
}
bool ceksinggung(point a, point b)
{
	if(a.x==b.x||a.y==b.y||(a.x+a.y)==(b.x+b.y)||(a.x-a.y)==(b.x-b.y)||(a.y-a.x)==(b.y-b.x))
	{return true;}
	else{return false;}
}
int main() {
	vector<point> vp;
	for(int i=0;i<8;i++)
	{
		string s;
		cin>>s;
		for(int j=0;j<s.length();j++)
		{
			if(s.substr(j,1)=="*")
			{
				point temp;
				temp.x=j+1;
				temp.y=i+1;
				vp.pb(temp);
			}
		}
	}
	bool singgung=false;
	for(int i=0;i<8;i++)
	{
		for(int j=0;j<8;j++)
		{
			if(i!=j)
			{
				singgung=singgung||ceksinggung(vp[i],vp[j]);
			}
		}
	}
	if(singgung){cout<<"invalid\n";}else{cout<<"valid\n";}
	return 0;
}
