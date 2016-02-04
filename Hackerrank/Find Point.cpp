#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
struct point{int x,y;};
int absolutey(int x)
{if(x<0){return x*-1;}else{return x;}}
point solve(int ax,int ay,int bx, int by)
{
    point p;
    p.x=ax+(2*(bx-ax));
    p.y=ay+(2*(by-ay));
    return p;
}
int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    int tc,ax,ay,bx,by,temp=0;
    cin>>tc;
    point res;
    while(temp<tc)
    {
        cin>>ax>>ay>>bx>>by;
        res=solve(ax,ay,bx,by);
        cout<<res.x<<" "<<res.y<<"\n";
        temp++;
    }
    return 0;
}
