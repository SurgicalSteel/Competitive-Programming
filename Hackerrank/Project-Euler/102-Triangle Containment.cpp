#include <bits/stdc++.h>
#include <algorithm>
using namespace std;
struct point{long long x;long long y;};
int absolutey(int x)
{if(x<0){return x*=-1;}else{return x;}}
long double area(point a, point b, point c)
{
	long double res=abs(((a.x*(b.y-c.y))+(b.x*(c.y-a.y))+(c.x*(a.y-b.y)))/2.0);
	return res;
}
bool check(point a,point b, point c, point p)
{
	long double abc=area(a,b,c);
	long double pab=area(p,a,b);
	long double pbc=area(p,b,c);
	long double pac=area(p,a,c);
	return (abc==pab+pbc+pac);
}

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    long long ax,ay,bx,by,cx,cy,counter=0,tc;
    point a,b,c,ori;
    ori.x=0;
    ori.y=0;
    scanf("%lld",&tc);
    for(int i=0;i<tc;i++)
    {
        scanf("%lld %lld %lld %lld %lld %lld",&ax,&ay,&bx,&by,&cx,&cy);
        a.x=ax;
        a.y=ay;
        b.x=bx;
        b.y=by;
        c.x=cx;
        c.y=cy;
        if(check(a,b,c,ori)){counter++;}
    }
    printf("%d\n",counter);
    return 0;
}
