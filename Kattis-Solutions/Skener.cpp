#include <bits/stdc++.h>
#define psb push_back
using namespace std;
int main() {
    int r,c,zr,zc;
    string temp;
    vector<string> init, builda,buildb;
    scanf("%d %d %d %d",&r,&c,&zr,&zc);
    for(int x=0;x<r;++x){cin>>temp;init.psb(temp);}
    if(zc>1){
        for(int i=0;i<r;++i)
        {
            temp="";
            for(int idx=0;idx<c;++idx)
            {
                for(int adder=0;adder<zc;++adder)
                {temp+=init[i].substr(idx,1);}
            }
            builda.psb(temp);
        }
    }
    else
    {
        for(int i=0;i<r;++i)
        {builda.psb(init[i]);}
    }
    if(zr>1)
    {
        for(int i=0;i<r;++i)
        {
            for(int x=0;x<zr;++x)
            {buildb.psb(builda[i]);}
        }
    }
    else
    {
        for(int i=0;i<r;++i)
        {buildb.psb(builda[i]);}
    }
    for(int i=0;i<buildb.size();++i){cout<<buildb[i]<<"\n";}
    return 0;
}
