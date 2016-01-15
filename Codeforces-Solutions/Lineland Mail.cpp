#include <bits/stdc++.h>
#include <algorithm>
#define puba push_back
using namespace std;
int absolutey(int x)
{
    if(x<0){return x*-1;}
    else{return x;}
}
int main() {
    int tc,x,mi,ma;
    vector<int> c,cs;
    cin>>tc;
    for(int i=0;i<tc;i++)
    {
        cin>>x;
        c.puba(x);
        cs.puba(x);
    }
    sort(cs.begin(),cs.end());
    vector<int>::iterator iter=cs.begin();
    for(int i=0;i<tc;i++)
    {
        //find elm
        iter=find(cs.begin(),cs.end(),c[i]);
        if(iter!=cs.end())
        {
            int pos=distance(cs.begin(),iter);
            if(pos==tc-1){mi=absolutey(cs[pos]-cs[tc-2]);}
            else if(pos==0){mi=absolutey(cs[pos]-cs[1]);}
            else {mi=min(absolutey(cs[pos]-cs[pos-1]),absolutey(cs[pos]-cs[pos+1]));}
            ma=max(absolutey(cs[pos]-cs[0]),absolutey(cs[pos]-cs[tc-1]));
            cout<<mi<<" "<<ma<<"\n";
        }
    }
    return 0;
}
