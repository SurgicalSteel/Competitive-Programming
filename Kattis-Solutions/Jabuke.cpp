#include <bits/stdc++.h>
using namespace std;
struct point{int x;int y;};
int absolutey(int x)
{if(x<0){return x*=-1;}else{return x;}}
float area(point a, point b, point c)
{
	float res=abs(((a.x*(b.y-c.y))+(b.x*(c.y-a.y))+(c.x*(a.y-b.y)))/2.0);
	return res;
}
bool check(point a,point b, point c, point p)
{
	float abc=area(a,b,c);
	float pab=area(p,a,b);
	float pbc=area(p,b,c);
	float pac=area(p,a,c);
	return (abc==pab+pbc+pac);
}
int main() {
	point a,b,c,p;
	cin>>a.x>>a.y>>b.x>>b.y>>c.x>>c.y;
	int num,ctr=0;
	cin>>num;
	float tarea= area(a,b,c);
	printf("%.1f\n",tarea);
	//cout.precision(1)<<tarea<<"\n";
	for(int i=0;i<num;i++)
	{
		cin>>p.x>>p.y;
		if(check(a,b,c,p)){ctr++;}
	}
	cout<<ctr<<"\n";
	return 0;
}
