#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
vector<int> sm,bg,res;
vector<bool> truth;
int main() {
    int na,nb,temp;
    scanf("%d",&na);
    for(int i=0;i<na;i++)
    {
        scanf("%d",&temp);
        sm.push_back(temp);
    }
    sort(sm.begin(),sm.end());
    scanf("%d",&nb);
    for(int i=0;i<nb;i++)
    {
        scanf("%d",&temp);
        bg.push_back(temp);
        truth.push_back(true);
    }
    sort(bg.begin(),bg.end());
    int lastidx=0;
    bool breaker;
    for(int i=0;i<na;i++)
    {
        breaker=false;
        while(lastidx<nb&&!breaker)
        {
            if(bg[lastidx]==sm[i]&&truth[lastidx]){truth[lastidx]=false;breaker=true;}
            lastidx++;
        }
    }
    for(int i=0;i<nb;i++)
    {if(truth[i]){res.push_back(bg[i]);}}
    int i=0;
    while(i<res.size())
    {
        while(res[i]==res[i+1]&&i+1<res.size()){i++;}
        printf("%d ",res[i]);
        i++;
    }
    printf("\n");
    return 0;
}
