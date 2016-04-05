#include <bits/stdc++.h>
using namespace std;
#define pb push_back
#define fs first
#define sc second
#define mp make_pair
int solve(vector<pair<int,int>> spdh)
{
    if(spdh.size()==1){return spdh[0].fs*spdh[0].sc;}
    else
    {
        int tot=0;
        for(int i=0;i<spdh.size();i++)
        {
            if(i==0){tot+=(spdh[i].fs*spdh[i].sc);}
            else{tot+=(spdh[i].fs*(spdh[i].sc-spdh[i-1].sc));}
        }
        return tot;
    }
}
int main() {
    int n,spd,h;
    cin>>n;
    while(n!=-1)
    {
        vector<pair<int,int>> spdh;
        for(int i=0;i<n;i++)
        {
            cin>>spd>>h;
            spdh.pb(mp(spd,h));
        }
        cout<<solve(spdh)<<" miles\n";
        cin>>n;
    }
    return 0;
}
