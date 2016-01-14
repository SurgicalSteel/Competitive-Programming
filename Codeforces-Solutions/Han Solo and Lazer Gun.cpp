#include <bits/stdc++.h>
using namespace std;
//solution for Han Solo and Lazer Gun (from http://codeforces.com/contest/514/problem/B)
//by SurgicalSteel a.k.a Yuwono Bangun Nagoro
//original source : http://codeforces.com/contest/514/submission/13507205
struct point{int x,y;};
struct koef{int a,b,c;};
koef makekoef(point han,point p)
{
    koef k;
    k.a=p.x-han.x;
    k.b=han.y-p.y;
    k.c=(p.x*han.y)-(han.x*p.y);
    return k;
}
int main() {
    // your code goes here
    int n;
    point han;
    cin>>n>>han.x>>han.y;
    point arrpoint[n];
    koef arrkoef[n];//hash lines
    for(int i=0;i<n;i++)
    {cin>>arrpoint[i].x>>arrpoint[i].y;}
    int i=0,ptrkoef=0;
    while(i<n)
    {
        if(i==0)
        {
            arrkoef[i]=makekoef(han,arrpoint[i]);
            ptrkoef++;
            i++;
        }
        else
        {
            bool found=false;
            int iter=0;
            while(iter<ptrkoef&&!found)
            {
                if((arrkoef[iter].a*arrpoint[i].y)+(arrkoef[iter].b*arrpoint[i].x)==arrkoef[iter].c)
                {found=true;}
                else{iter++;}
            }
            if(!found)
            {
                arrkoef[ptrkoef]=makekoef(han,arrpoint[i]);
                ptrkoef++;
            }
            i++;
        }
    }
    cout<<ptrkoef<<"\n";
    return 0;
}
