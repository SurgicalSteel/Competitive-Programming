#include <bits/stdc++.h>
using namespace std;
#define psb push_back
int kadane(vector<int> v,bool nopos)
{
    if(nopos)
    {
        vector<int>::iterator iter= max_element(v.begin(),v.end());
        return v[distance(v.begin(),iter)];
    }
    int max_so_far=0,max_ending_here=0;
    for(int i=0;i<v.size();++i)
    {
        max_ending_here+=v[i];
        if(max_ending_here>max_so_far){max_so_far=max_ending_here;}
        if(max_ending_here<0){max_ending_here=0;}
    }
    return max_so_far;
}
int main() {
    int tc,temp,sz,nonc,c;
    bool nopos;
    scanf("%d",&tc);
    while(tc--)
    {
        nopos=true;
        nonc=0;
        vector<int> v;
        scanf("%d",&sz);
        while(sz--)
        {
            scanf("%d",&temp);
            if(temp>=0){nonc+=temp;nopos=false;}
            v.psb(temp);
        }
        c=kadane(v,nopos);
        if(nopos){nonc=c;}
        printf("%d %d\n",c,nonc);
    }
    return 0;
}
