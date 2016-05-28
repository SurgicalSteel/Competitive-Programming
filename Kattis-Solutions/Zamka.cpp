#include <bits/stdc++.h>
using namespace std;
int toInt(string x)
{
    istringstream ss(x);
    int a;
    ss>>a;
    return a;
}
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
int sumdigit(string a)
{
    int sum=0;
    for(int x=0;x<a.length();x++){sum+=toInt(a.substr(x,1));}
    return sum;
}
int main() {
	int l,d,x;
	scanf("%d %d %d",&l,&d,&x);
	int i=0,mini,maxi,curr;
	bool found=false;
	curr=l;
	while(!found)
	{
		if(sumdigit(tostr(curr))==x){mini=curr;found=true;}
		curr++;
	}
	curr=d;
	found=false;
	while(!found)
	{
		if(sumdigit(tostr(curr))==x){maxi=curr;found=true;}
		curr--;
	}
	printf("%d\n%d\n",mini,maxi);
	return 0;
}
