#include <bits/stdc++.h>
#include <algorithm>
#define pb push_back
using namespace std;

int main() {
    int tc,x;
    vector<int> stat;
    cin>>tc;
    for(int i=0;i<tc;i++)
    {
        cin>>x;
        stat.pb(x);
    }
    sort(stat.begin(),stat.end());
    int i=0;
    while(i<tc)
    {
        if(stat[i]+1==stat[i+1]&&stat[i+1]+1==stat[i+2])
        {
            if(i==0){cout<<stat[i]<<"-";}else{cout<<" "<<stat[i]<<"-";}
            i+=2;
            bool sama;
            if(stat[i]+1==stat[i+1]){sama=true;}
            while(sama)
            {
                i++;
                if(stat[i]+1==stat[i+1]){sama=true;}
                else{sama=false;}
            }
            if (!sama){cout<<stat[i];}
        }
        else{cout<<" "<<stat[i];}
        i++;
    }
    return 0;
}
