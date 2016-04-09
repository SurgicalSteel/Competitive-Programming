#include <bits/stdc++.h>
#define psb push_back
using namespace std;
void display(int x, int y, int z)
{
	vector<int> v;
	v.psb(x);
	v.psb(y);
	v.psb(z);
	sort(v.begin(),v.end());
	cout<<v[2]<<" "<<v[1]<<" "<<v[0]<<" ";
}
int main() {
	// your code goes here
	int a,b,c,d,e,f,ts,td;
	scanf("%d %d %d %d %d %d %d %d",&a ,&b ,&c ,&d ,&e ,&f ,&ts,&td);
	if(a +b +c ==ts)
	{
		display(a,b,c);
		display(d,e,f);
		cout<<"\n";
	}else
	if(d +e +f ==ts)
	{
		display(d,e,f);
		display(a,b,c);
		cout<<"\n";
	}else
	if(a +c +d ==ts)
	{
		display(a,c,d);
		display(b,e,f);
		cout<<"\n";
	}else
	if(b +e +f ==ts)
	{
		display(b,e,f);
		display(a,c,d);
		cout<<"\n";
	}else
	if(a +d +e ==ts)
	{
		display(a,d,e);
		display(b,c,f);
		cout<<"\n";
	}else
	if(b +c +f ==ts)
	{
		display(b,c,f);
		display(a,d,e);
		cout<<"\n";
	}else
	if(a +e +f ==ts)
	{
		display(a,e,f);
		display(b,c,d);
		cout<<"\n";
	}else
	if(b +c +d ==ts)
	{
		display(b,c,d);
		display(a,e,f);
		cout<<"\n";
	}else
	if(b +d +e ==ts)
	{
		display(b,d,e);
		display(a,c,f);
		cout<<"\n";
	}else
if(a +c +f ==ts)
	{
		display(a,c,f);
		display(b,d,e);
		cout<<"\n";
	}else

	if(c +e +d ==ts)
	{
		display(c,d,e);
		display(a,b,f);
		cout<<"\n";
	}else
	if(a +b +f ==ts)
	{
		display(a,b,f);
		display(c,d,e);
		cout<<"\n";
	}else
	if(c +e +f ==ts)
	{
		display(c,e,f);
		display(a,b,d);
		cout<<"\n";
	}else
	if(a +b +d ==ts)
	{
		display(a,b,d);
		display(c,e,f);
		cout<<"\n";
	}else
	if(c +d +f ==ts)
	{
		display(c,d,f);
		display(a,b,e);
		cout<<"\n";
	}else
	if(a +b +e ==ts)
	{
		display(a,b,e);
		display(c,d,f);
		cout<<"\n";
	}else
	if(b +d +f ==ts)
	{
		display(b,d,f);
		display(a,c,e);
		cout<<"\n";
	}else
	if(a +c +e ==ts)
	{
		display(a,c,e);
		display(b,d,f);
		cout<<"\n";
	}
	else
	if(b +c +e ==ts)
	{
		display(b,c,e);
		display(a,d,f);
		cout<<"\n";
	}else
	if(a +d +f ==ts)
	{
		display(a,d,f);
		display(b,c,e);
		cout<<"\n";
	}
	return 0;
}
