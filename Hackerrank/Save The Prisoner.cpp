#include <bits/stdc++.h>
using namespace std;
int solve(int p, int m, int s)
{
    m%=p;
    if(m==1&&s>1){return s;}
    if(s==1&&m>0){return m;}
    else if(m==0)
    {
        if(s==1){return p;}
        else return m+1;
    }
    else {
        m--;
        if((m+s)>p){return abs(p-(m+s));}
        else{return m+s;}
    }
}
int main() {
    int tc,p,m,s;
    scanf("%d",&tc);
    while(tc--)
    {
        scanf("%d %d %d",&p,&m,&s);
        printf("%d\n",solve(p,m,s));
    }
    return 0;
}
